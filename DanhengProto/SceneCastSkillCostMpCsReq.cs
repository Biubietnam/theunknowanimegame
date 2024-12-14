using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001051 RID: 4177
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneCastSkillCostMpCsReq : IMessage<SceneCastSkillCostMpCsReq>, IMessage, IEquatable<SceneCastSkillCostMpCsReq>, IDeepCloneable<SceneCastSkillCostMpCsReq>, IBufferMessage
	{
		// Token: 0x17003469 RID: 13417
		// (get) Token: 0x0600B9EB RID: 47595 RVA: 0x001F3821 File Offset: 0x001F1A21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneCastSkillCostMpCsReq> Parser
		{
			get
			{
				return SceneCastSkillCostMpCsReq._parser;
			}
		}

		// Token: 0x1700346A RID: 13418
		// (get) Token: 0x0600B9EC RID: 47596 RVA: 0x001F3828 File Offset: 0x001F1A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneCastSkillCostMpCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700346B RID: 13419
		// (get) Token: 0x0600B9ED RID: 47597 RVA: 0x001F383A File Offset: 0x001F1A3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneCastSkillCostMpCsReq.Descriptor;
			}
		}

		// Token: 0x0600B9EE RID: 47598 RVA: 0x001F3841 File Offset: 0x001F1A41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneCastSkillCostMpCsReq()
		{
		}

		// Token: 0x0600B9EF RID: 47599 RVA: 0x001F3849 File Offset: 0x001F1A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneCastSkillCostMpCsReq(SceneCastSkillCostMpCsReq other) : this()
		{
			this.attackedByEntityId_ = other.attackedByEntityId_;
			this.skillIndex_ = other.skillIndex_;
			this.castEntityId_ = other.castEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B9F0 RID: 47600 RVA: 0x001F3886 File Offset: 0x001F1A86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneCastSkillCostMpCsReq Clone()
		{
			return new SceneCastSkillCostMpCsReq(this);
		}

		// Token: 0x1700346C RID: 13420
		// (get) Token: 0x0600B9F1 RID: 47601 RVA: 0x001F388E File Offset: 0x001F1A8E
		// (set) Token: 0x0600B9F2 RID: 47602 RVA: 0x001F3896 File Offset: 0x001F1A96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AttackedByEntityId
		{
			get
			{
				return this.attackedByEntityId_;
			}
			set
			{
				this.attackedByEntityId_ = value;
			}
		}

		// Token: 0x1700346D RID: 13421
		// (get) Token: 0x0600B9F3 RID: 47603 RVA: 0x001F389F File Offset: 0x001F1A9F
		// (set) Token: 0x0600B9F4 RID: 47604 RVA: 0x001F38A7 File Offset: 0x001F1AA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SkillIndex
		{
			get
			{
				return this.skillIndex_;
			}
			set
			{
				this.skillIndex_ = value;
			}
		}

		// Token: 0x1700346E RID: 13422
		// (get) Token: 0x0600B9F5 RID: 47605 RVA: 0x001F38B0 File Offset: 0x001F1AB0
		// (set) Token: 0x0600B9F6 RID: 47606 RVA: 0x001F38B8 File Offset: 0x001F1AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CastEntityId
		{
			get
			{
				return this.castEntityId_;
			}
			set
			{
				this.castEntityId_ = value;
			}
		}

		// Token: 0x0600B9F7 RID: 47607 RVA: 0x001F38C1 File Offset: 0x001F1AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneCastSkillCostMpCsReq);
		}

		// Token: 0x0600B9F8 RID: 47608 RVA: 0x001F38D0 File Offset: 0x001F1AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneCastSkillCostMpCsReq other)
		{
			return other != null && (other == this || (this.AttackedByEntityId == other.AttackedByEntityId && this.SkillIndex == other.SkillIndex && this.CastEntityId == other.CastEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B9F9 RID: 47609 RVA: 0x001F392C File Offset: 0x001F1B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AttackedByEntityId != 0U)
			{
				num ^= this.AttackedByEntityId.GetHashCode();
			}
			if (this.SkillIndex != 0U)
			{
				num ^= this.SkillIndex.GetHashCode();
			}
			if (this.CastEntityId != 0U)
			{
				num ^= this.CastEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B9FA RID: 47610 RVA: 0x001F399D File Offset: 0x001F1B9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B9FB RID: 47611 RVA: 0x001F39A5 File Offset: 0x001F1BA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B9FC RID: 47612 RVA: 0x001F39B0 File Offset: 0x001F1BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillIndex != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.SkillIndex);
			}
			if (this.AttackedByEntityId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.AttackedByEntityId);
			}
			if (this.CastEntityId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.CastEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B9FD RID: 47613 RVA: 0x001F3A28 File Offset: 0x001F1C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AttackedByEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AttackedByEntityId);
			}
			if (this.SkillIndex != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SkillIndex);
			}
			if (this.CastEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CastEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B9FE RID: 47614 RVA: 0x001F3A98 File Offset: 0x001F1C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneCastSkillCostMpCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AttackedByEntityId != 0U)
			{
				this.AttackedByEntityId = other.AttackedByEntityId;
			}
			if (other.SkillIndex != 0U)
			{
				this.SkillIndex = other.SkillIndex;
			}
			if (other.CastEntityId != 0U)
			{
				this.CastEntityId = other.CastEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B9FF RID: 47615 RVA: 0x001F3AFC File Offset: 0x001F1CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BA00 RID: 47616 RVA: 0x001F3B08 File Offset: 0x001F1D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 80U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CastEntityId = input.ReadUInt32();
						}
					}
					else
					{
						this.AttackedByEntityId = input.ReadUInt32();
					}
				}
				else
				{
					this.SkillIndex = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004B5C RID: 19292
		private static readonly MessageParser<SceneCastSkillCostMpCsReq> _parser = new MessageParser<SceneCastSkillCostMpCsReq>(() => new SceneCastSkillCostMpCsReq());

		// Token: 0x04004B5D RID: 19293
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B5E RID: 19294
		public const int AttackedByEntityIdFieldNumber = 10;

		// Token: 0x04004B5F RID: 19295
		private uint attackedByEntityId_;

		// Token: 0x04004B60 RID: 19296
		public const int SkillIndexFieldNumber = 3;

		// Token: 0x04004B61 RID: 19297
		private uint skillIndex_;

		// Token: 0x04004B62 RID: 19298
		public const int CastEntityIdFieldNumber = 11;

		// Token: 0x04004B63 RID: 19299
		private uint castEntityId_;
	}
}
