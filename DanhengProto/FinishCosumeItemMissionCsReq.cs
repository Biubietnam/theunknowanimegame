using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200056D RID: 1389
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishCosumeItemMissionCsReq : IMessage<FinishCosumeItemMissionCsReq>, IMessage, IEquatable<FinishCosumeItemMissionCsReq>, IDeepCloneable<FinishCosumeItemMissionCsReq>, IBufferMessage
	{
		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x06003DF5 RID: 15861 RVA: 0x000A990D File Offset: 0x000A7B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishCosumeItemMissionCsReq> Parser
		{
			get
			{
				return FinishCosumeItemMissionCsReq._parser;
			}
		}

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x06003DF6 RID: 15862 RVA: 0x000A9914 File Offset: 0x000A7B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishCosumeItemMissionCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x06003DF7 RID: 15863 RVA: 0x000A9926 File Offset: 0x000A7B26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishCosumeItemMissionCsReq.Descriptor;
			}
		}

		// Token: 0x06003DF8 RID: 15864 RVA: 0x000A992D File Offset: 0x000A7B2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishCosumeItemMissionCsReq()
		{
		}

		// Token: 0x06003DF9 RID: 15865 RVA: 0x000A9938 File Offset: 0x000A7B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishCosumeItemMissionCsReq(FinishCosumeItemMissionCsReq other) : this()
		{
			this.itemList_ = ((other.itemList_ != null) ? other.itemList_.Clone() : null);
			this.subMissionId_ = other.subMissionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003DFA RID: 15866 RVA: 0x000A9984 File Offset: 0x000A7B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishCosumeItemMissionCsReq Clone()
		{
			return new FinishCosumeItemMissionCsReq(this);
		}

		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x06003DFB RID: 15867 RVA: 0x000A998C File Offset: 0x000A7B8C
		// (set) Token: 0x06003DFC RID: 15868 RVA: 0x000A9994 File Offset: 0x000A7B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList ItemList
		{
			get
			{
				return this.itemList_;
			}
			set
			{
				this.itemList_ = value;
			}
		}

		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x06003DFD RID: 15869 RVA: 0x000A999D File Offset: 0x000A7B9D
		// (set) Token: 0x06003DFE RID: 15870 RVA: 0x000A99A5 File Offset: 0x000A7BA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SubMissionId
		{
			get
			{
				return this.subMissionId_;
			}
			set
			{
				this.subMissionId_ = value;
			}
		}

		// Token: 0x06003DFF RID: 15871 RVA: 0x000A99AE File Offset: 0x000A7BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishCosumeItemMissionCsReq);
		}

		// Token: 0x06003E00 RID: 15872 RVA: 0x000A99BC File Offset: 0x000A7BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishCosumeItemMissionCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.ItemList, other.ItemList) && this.SubMissionId == other.SubMissionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003E01 RID: 15873 RVA: 0x000A9A0C File Offset: 0x000A7C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.itemList_ != null)
			{
				num ^= this.ItemList.GetHashCode();
			}
			if (this.SubMissionId != 0U)
			{
				num ^= this.SubMissionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003E02 RID: 15874 RVA: 0x000A9A61 File Offset: 0x000A7C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003E03 RID: 15875 RVA: 0x000A9A69 File Offset: 0x000A7C69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E04 RID: 15876 RVA: 0x000A9A74 File Offset: 0x000A7C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.itemList_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ItemList);
			}
			if (this.SubMissionId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.SubMissionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003E05 RID: 15877 RVA: 0x000A9AD0 File Offset: 0x000A7CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.itemList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ItemList);
			}
			if (this.SubMissionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SubMissionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003E06 RID: 15878 RVA: 0x000A9B28 File Offset: 0x000A7D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishCosumeItemMissionCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.itemList_ != null)
			{
				if (this.itemList_ == null)
				{
					this.ItemList = new ItemList();
				}
				this.ItemList.MergeFrom(other.ItemList);
			}
			if (other.SubMissionId != 0U)
			{
				this.SubMissionId = other.SubMissionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003E07 RID: 15879 RVA: 0x000A9B90 File Offset: 0x000A7D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E08 RID: 15880 RVA: 0x000A9B9C File Offset: 0x000A7D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SubMissionId = input.ReadUInt32();
					}
				}
				else
				{
					if (this.itemList_ == null)
					{
						this.ItemList = new ItemList();
					}
					input.ReadMessage(this.ItemList);
				}
			}
		}

		// Token: 0x040018C4 RID: 6340
		private static readonly MessageParser<FinishCosumeItemMissionCsReq> _parser = new MessageParser<FinishCosumeItemMissionCsReq>(() => new FinishCosumeItemMissionCsReq());

		// Token: 0x040018C5 RID: 6341
		private UnknownFieldSet _unknownFields;

		// Token: 0x040018C6 RID: 6342
		public const int ItemListFieldNumber = 2;

		// Token: 0x040018C7 RID: 6343
		private ItemList itemList_;

		// Token: 0x040018C8 RID: 6344
		public const int SubMissionIdFieldNumber = 9;

		// Token: 0x040018C9 RID: 6345
		private uint subMissionId_;
	}
}
