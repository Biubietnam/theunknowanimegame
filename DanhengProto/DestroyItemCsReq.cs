using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200038B RID: 907
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DestroyItemCsReq : IMessage<DestroyItemCsReq>, IMessage, IEquatable<DestroyItemCsReq>, IDeepCloneable<DestroyItemCsReq>, IBufferMessage
	{
		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06002852 RID: 10322 RVA: 0x00070261 File Offset: 0x0006E461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DestroyItemCsReq> Parser
		{
			get
			{
				return DestroyItemCsReq._parser;
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x06002853 RID: 10323 RVA: 0x00070268 File Offset: 0x0006E468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DestroyItemCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x06002854 RID: 10324 RVA: 0x0007027A File Offset: 0x0006E47A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DestroyItemCsReq.Descriptor;
			}
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x00070281 File Offset: 0x0006E481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyItemCsReq()
		{
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x00070289 File Offset: 0x0006E489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyItemCsReq(DestroyItemCsReq other) : this()
		{
			this.curItemCount_ = other.curItemCount_;
			this.itemId_ = other.itemId_;
			this.itemCount_ = other.itemCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x000702C6 File Offset: 0x0006E4C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyItemCsReq Clone()
		{
			return new DestroyItemCsReq(this);
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x06002858 RID: 10328 RVA: 0x000702CE File Offset: 0x0006E4CE
		// (set) Token: 0x06002859 RID: 10329 RVA: 0x000702D6 File Offset: 0x0006E4D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurItemCount
		{
			get
			{
				return this.curItemCount_;
			}
			set
			{
				this.curItemCount_ = value;
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x0600285A RID: 10330 RVA: 0x000702DF File Offset: 0x0006E4DF
		// (set) Token: 0x0600285B RID: 10331 RVA: 0x000702E7 File Offset: 0x0006E4E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x0600285C RID: 10332 RVA: 0x000702F0 File Offset: 0x0006E4F0
		// (set) Token: 0x0600285D RID: 10333 RVA: 0x000702F8 File Offset: 0x0006E4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemCount
		{
			get
			{
				return this.itemCount_;
			}
			set
			{
				this.itemCount_ = value;
			}
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x00070301 File Offset: 0x0006E501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DestroyItemCsReq);
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x00070310 File Offset: 0x0006E510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DestroyItemCsReq other)
		{
			return other != null && (other == this || (this.CurItemCount == other.CurItemCount && this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x0007036C File Offset: 0x0006E56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurItemCount != 0U)
			{
				num ^= this.CurItemCount.GetHashCode();
			}
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemCount != 0U)
			{
				num ^= this.ItemCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x000703DD File Offset: 0x0006E5DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x000703E5 File Offset: 0x0006E5E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x000703F0 File Offset: 0x0006E5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurItemCount != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.CurItemCount);
			}
			if (this.ItemCount != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.ItemCount);
			}
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x00070468 File Offset: 0x0006E668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurItemCount != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurItemCount);
			}
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this.ItemCount != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x000704D8 File Offset: 0x0006E6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DestroyItemCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurItemCount != 0U)
			{
				this.CurItemCount = other.CurItemCount;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemCount != 0U)
			{
				this.ItemCount = other.ItemCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x0007053C File Offset: 0x0006E73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x00070548 File Offset: 0x0006E748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 80U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ItemId = input.ReadUInt32();
						}
					}
					else
					{
						this.ItemCount = input.ReadUInt32();
					}
				}
				else
				{
					this.CurItemCount = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001032 RID: 4146
		private static readonly MessageParser<DestroyItemCsReq> _parser = new MessageParser<DestroyItemCsReq>(() => new DestroyItemCsReq());

		// Token: 0x04001033 RID: 4147
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001034 RID: 4148
		public const int CurItemCountFieldNumber = 7;

		// Token: 0x04001035 RID: 4149
		private uint curItemCount_;

		// Token: 0x04001036 RID: 4150
		public const int ItemIdFieldNumber = 15;

		// Token: 0x04001037 RID: 4151
		private uint itemId_;

		// Token: 0x04001038 RID: 4152
		public const int ItemCountFieldNumber = 10;

		// Token: 0x04001039 RID: 4153
		private uint itemCount_;
	}
}
