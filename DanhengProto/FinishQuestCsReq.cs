using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200058F RID: 1423
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishQuestCsReq : IMessage<FinishQuestCsReq>, IMessage, IEquatable<FinishQuestCsReq>, IDeepCloneable<FinishQuestCsReq>, IBufferMessage
	{
		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x06003F81 RID: 16257 RVA: 0x000AD455 File Offset: 0x000AB655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishQuestCsReq> Parser
		{
			get
			{
				return FinishQuestCsReq._parser;
			}
		}

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x06003F82 RID: 16258 RVA: 0x000AD45C File Offset: 0x000AB65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishQuestCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x06003F83 RID: 16259 RVA: 0x000AD46E File Offset: 0x000AB66E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishQuestCsReq.Descriptor;
			}
		}

		// Token: 0x06003F84 RID: 16260 RVA: 0x000AD475 File Offset: 0x000AB675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishQuestCsReq()
		{
		}

		// Token: 0x06003F85 RID: 16261 RVA: 0x000AD47D File Offset: 0x000AB67D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishQuestCsReq(FinishQuestCsReq other) : this()
		{
			this.groupId_ = other.groupId_;
			this.propId_ = other.propId_;
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F86 RID: 16262 RVA: 0x000AD4BA File Offset: 0x000AB6BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishQuestCsReq Clone()
		{
			return new FinishQuestCsReq(this);
		}

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x06003F87 RID: 16263 RVA: 0x000AD4C2 File Offset: 0x000AB6C2
		// (set) Token: 0x06003F88 RID: 16264 RVA: 0x000AD4CA File Offset: 0x000AB6CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x06003F89 RID: 16265 RVA: 0x000AD4D3 File Offset: 0x000AB6D3
		// (set) Token: 0x06003F8A RID: 16266 RVA: 0x000AD4DB File Offset: 0x000AB6DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PropId
		{
			get
			{
				return this.propId_;
			}
			set
			{
				this.propId_ = value;
			}
		}

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x06003F8B RID: 16267 RVA: 0x000AD4E4 File Offset: 0x000AB6E4
		// (set) Token: 0x06003F8C RID: 16268 RVA: 0x000AD4EC File Offset: 0x000AB6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint QuestId
		{
			get
			{
				return this.questId_;
			}
			set
			{
				this.questId_ = value;
			}
		}

		// Token: 0x06003F8D RID: 16269 RVA: 0x000AD4F5 File Offset: 0x000AB6F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishQuestCsReq);
		}

		// Token: 0x06003F8E RID: 16270 RVA: 0x000AD504 File Offset: 0x000AB704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishQuestCsReq other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.PropId == other.PropId && this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003F8F RID: 16271 RVA: 0x000AD560 File Offset: 0x000AB760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.PropId != 0U)
			{
				num ^= this.PropId.GetHashCode();
			}
			if (this.QuestId != 0U)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003F90 RID: 16272 RVA: 0x000AD5D1 File Offset: 0x000AB7D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003F91 RID: 16273 RVA: 0x000AD5D9 File Offset: 0x000AB7D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F92 RID: 16274 RVA: 0x000AD5E4 File Offset: 0x000AB7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.GroupId);
			}
			if (this.QuestId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.QuestId);
			}
			if (this.PropId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.PropId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x000AD65C File Offset: 0x000AB85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this.PropId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PropId);
			}
			if (this.QuestId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003F94 RID: 16276 RVA: 0x000AD6CC File Offset: 0x000AB8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishQuestCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			if (other.PropId != 0U)
			{
				this.PropId = other.PropId;
			}
			if (other.QuestId != 0U)
			{
				this.QuestId = other.QuestId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003F95 RID: 16277 RVA: 0x000AD730 File Offset: 0x000AB930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F96 RID: 16278 RVA: 0x000AD73C File Offset: 0x000AB93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 72U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PropId = input.ReadUInt32();
						}
					}
					else
					{
						this.QuestId = input.ReadUInt32();
					}
				}
				else
				{
					this.GroupId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001946 RID: 6470
		private static readonly MessageParser<FinishQuestCsReq> _parser = new MessageParser<FinishQuestCsReq>(() => new FinishQuestCsReq());

		// Token: 0x04001947 RID: 6471
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001948 RID: 6472
		public const int GroupIdFieldNumber = 3;

		// Token: 0x04001949 RID: 6473
		private uint groupId_;

		// Token: 0x0400194A RID: 6474
		public const int PropIdFieldNumber = 13;

		// Token: 0x0400194B RID: 6475
		private uint propId_;

		// Token: 0x0400194C RID: 6476
		public const int QuestIdFieldNumber = 9;

		// Token: 0x0400194D RID: 6477
		private uint questId_;
	}
}
