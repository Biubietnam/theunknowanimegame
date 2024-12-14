using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000BF RID: 191
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AvatarExpUpCsReq : IMessage<AvatarExpUpCsReq>, IMessage, IEquatable<AvatarExpUpCsReq>, IDeepCloneable<AvatarExpUpCsReq>, IBufferMessage
	{
		// Token: 0x1700027D RID: 637
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x00019A19 File Offset: 0x00017C19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AvatarExpUpCsReq> Parser
		{
			get
			{
				return AvatarExpUpCsReq._parser;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x00019A20 File Offset: 0x00017C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AvatarExpUpCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x00019A32 File Offset: 0x00017C32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvatarExpUpCsReq.Descriptor;
			}
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00019A39 File Offset: 0x00017C39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarExpUpCsReq()
		{
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00019A44 File Offset: 0x00017C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarExpUpCsReq(AvatarExpUpCsReq other) : this()
		{
			this.baseAvatarId_ = other.baseAvatarId_;
			this.itemCost_ = ((other.itemCost_ != null) ? other.itemCost_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00019A90 File Offset: 0x00017C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarExpUpCsReq Clone()
		{
			return new AvatarExpUpCsReq(this);
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x00019A98 File Offset: 0x00017C98
		// (set) Token: 0x06000896 RID: 2198 RVA: 0x00019AA0 File Offset: 0x00017CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BaseAvatarId
		{
			get
			{
				return this.baseAvatarId_;
			}
			set
			{
				this.baseAvatarId_ = value;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x00019AA9 File Offset: 0x00017CA9
		// (set) Token: 0x06000898 RID: 2200 RVA: 0x00019AB1 File Offset: 0x00017CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemCostData ItemCost
		{
			get
			{
				return this.itemCost_;
			}
			set
			{
				this.itemCost_ = value;
			}
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00019ABA File Offset: 0x00017CBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvatarExpUpCsReq);
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00019AC8 File Offset: 0x00017CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvatarExpUpCsReq other)
		{
			return other != null && (other == this || (this.BaseAvatarId == other.BaseAvatarId && object.Equals(this.ItemCost, other.ItemCost) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00019B18 File Offset: 0x00017D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BaseAvatarId != 0U)
			{
				num ^= this.BaseAvatarId.GetHashCode();
			}
			if (this.itemCost_ != null)
			{
				num ^= this.ItemCost.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00019B6D File Offset: 0x00017D6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00019B75 File Offset: 0x00017D75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00019B80 File Offset: 0x00017D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BaseAvatarId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.BaseAvatarId);
			}
			if (this.itemCost_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.ItemCost);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00019BDC File Offset: 0x00017DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BaseAvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BaseAvatarId);
			}
			if (this.itemCost_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ItemCost);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00019C34 File Offset: 0x00017E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AvatarExpUpCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BaseAvatarId != 0U)
			{
				this.BaseAvatarId = other.BaseAvatarId;
			}
			if (other.itemCost_ != null)
			{
				if (this.itemCost_ == null)
				{
					this.ItemCost = new ItemCostData();
				}
				this.ItemCost.MergeFrom(other.ItemCost);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00019C9C File Offset: 0x00017E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00019CA8 File Offset: 0x00017EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.itemCost_ == null)
						{
							this.ItemCost = new ItemCostData();
						}
						input.ReadMessage(this.ItemCost);
					}
				}
				else
				{
					this.BaseAvatarId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000385 RID: 901
		private static readonly MessageParser<AvatarExpUpCsReq> _parser = new MessageParser<AvatarExpUpCsReq>(() => new AvatarExpUpCsReq());

		// Token: 0x04000386 RID: 902
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000387 RID: 903
		public const int BaseAvatarIdFieldNumber = 12;

		// Token: 0x04000388 RID: 904
		private uint baseAvatarId_;

		// Token: 0x04000389 RID: 905
		public const int ItemCostFieldNumber = 14;

		// Token: 0x0400038A RID: 906
		private ItemCostData itemCost_;
	}
}
