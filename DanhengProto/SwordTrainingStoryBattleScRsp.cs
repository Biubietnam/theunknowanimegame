using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001253 RID: 4691
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingStoryBattleScRsp : IMessage<SwordTrainingStoryBattleScRsp>, IMessage, IEquatable<SwordTrainingStoryBattleScRsp>, IDeepCloneable<SwordTrainingStoryBattleScRsp>, IBufferMessage
	{
		// Token: 0x17003AFC RID: 15100
		// (get) Token: 0x0600D176 RID: 53622 RVA: 0x00230373 File Offset: 0x0022E573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingStoryBattleScRsp> Parser
		{
			get
			{
				return SwordTrainingStoryBattleScRsp._parser;
			}
		}

		// Token: 0x17003AFD RID: 15101
		// (get) Token: 0x0600D177 RID: 53623 RVA: 0x0023037A File Offset: 0x0022E57A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingStoryBattleScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003AFE RID: 15102
		// (get) Token: 0x0600D178 RID: 53624 RVA: 0x0023038C File Offset: 0x0022E58C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingStoryBattleScRsp.Descriptor;
			}
		}

		// Token: 0x0600D179 RID: 53625 RVA: 0x00230393 File Offset: 0x0022E593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingStoryBattleScRsp()
		{
		}

		// Token: 0x0600D17A RID: 53626 RVA: 0x0023039C File Offset: 0x0022E59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingStoryBattleScRsp(SwordTrainingStoryBattleScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D17B RID: 53627 RVA: 0x002303E8 File Offset: 0x0022E5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingStoryBattleScRsp Clone()
		{
			return new SwordTrainingStoryBattleScRsp(this);
		}

		// Token: 0x17003AFF RID: 15103
		// (get) Token: 0x0600D17C RID: 53628 RVA: 0x002303F0 File Offset: 0x0022E5F0
		// (set) Token: 0x0600D17D RID: 53629 RVA: 0x002303F8 File Offset: 0x0022E5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17003B00 RID: 15104
		// (get) Token: 0x0600D17E RID: 53630 RVA: 0x00230401 File Offset: 0x0022E601
		// (set) Token: 0x0600D17F RID: 53631 RVA: 0x00230409 File Offset: 0x0022E609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBattleInfo BattleInfo
		{
			get
			{
				return this.battleInfo_;
			}
			set
			{
				this.battleInfo_ = value;
			}
		}

		// Token: 0x0600D180 RID: 53632 RVA: 0x00230412 File Offset: 0x0022E612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingStoryBattleScRsp);
		}

		// Token: 0x0600D181 RID: 53633 RVA: 0x00230420 File Offset: 0x0022E620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingStoryBattleScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.BattleInfo, other.BattleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D182 RID: 53634 RVA: 0x00230470 File Offset: 0x0022E670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.battleInfo_ != null)
			{
				num ^= this.BattleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D183 RID: 53635 RVA: 0x002304C5 File Offset: 0x0022E6C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D184 RID: 53636 RVA: 0x002304CD File Offset: 0x0022E6CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D185 RID: 53637 RVA: 0x002304D8 File Offset: 0x0022E6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.BattleInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D186 RID: 53638 RVA: 0x00230534 File Offset: 0x0022E734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.battleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D187 RID: 53639 RVA: 0x0023058C File Offset: 0x0022E78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingStoryBattleScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.battleInfo_ != null)
			{
				if (this.battleInfo_ == null)
				{
					this.BattleInfo = new SceneBattleInfo();
				}
				this.BattleInfo.MergeFrom(other.BattleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D188 RID: 53640 RVA: 0x002305F4 File Offset: 0x0022E7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D189 RID: 53641 RVA: 0x00230600 File Offset: 0x0022E800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.battleInfo_ == null)
					{
						this.BattleInfo = new SceneBattleInfo();
					}
					input.ReadMessage(this.BattleInfo);
				}
			}
		}

		// Token: 0x04005409 RID: 21513
		private static readonly MessageParser<SwordTrainingStoryBattleScRsp> _parser = new MessageParser<SwordTrainingStoryBattleScRsp>(() => new SwordTrainingStoryBattleScRsp());

		// Token: 0x0400540A RID: 21514
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400540B RID: 21515
		public const int RetcodeFieldNumber = 14;

		// Token: 0x0400540C RID: 21516
		private uint retcode_;

		// Token: 0x0400540D RID: 21517
		public const int BattleInfoFieldNumber = 3;

		// Token: 0x0400540E RID: 21518
		private SceneBattleInfo battleInfo_;
	}
}
