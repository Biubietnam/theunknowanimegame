using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200046D RID: 1133
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterStrongChallengeActivityStageScRsp : IMessage<EnterStrongChallengeActivityStageScRsp>, IMessage, IEquatable<EnterStrongChallengeActivityStageScRsp>, IDeepCloneable<EnterStrongChallengeActivityStageScRsp>, IBufferMessage
	{
		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06003270 RID: 12912 RVA: 0x0008AC7B File Offset: 0x00088E7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterStrongChallengeActivityStageScRsp> Parser
		{
			get
			{
				return EnterStrongChallengeActivityStageScRsp._parser;
			}
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06003271 RID: 12913 RVA: 0x0008AC82 File Offset: 0x00088E82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterStrongChallengeActivityStageScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06003272 RID: 12914 RVA: 0x0008AC94 File Offset: 0x00088E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterStrongChallengeActivityStageScRsp.Descriptor;
			}
		}

		// Token: 0x06003273 RID: 12915 RVA: 0x0008AC9B File Offset: 0x00088E9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterStrongChallengeActivityStageScRsp()
		{
		}

		// Token: 0x06003274 RID: 12916 RVA: 0x0008ACA4 File Offset: 0x00088EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterStrongChallengeActivityStageScRsp(EnterStrongChallengeActivityStageScRsp other) : this()
		{
			this.stageId_ = other.stageId_;
			this.retcode_ = other.retcode_;
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003275 RID: 12917 RVA: 0x0008ACFC File Offset: 0x00088EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterStrongChallengeActivityStageScRsp Clone()
		{
			return new EnterStrongChallengeActivityStageScRsp(this);
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06003276 RID: 12918 RVA: 0x0008AD04 File Offset: 0x00088F04
		// (set) Token: 0x06003277 RID: 12919 RVA: 0x0008AD0C File Offset: 0x00088F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint StageId
		{
			get
			{
				return this.stageId_;
			}
			set
			{
				this.stageId_ = value;
			}
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06003278 RID: 12920 RVA: 0x0008AD15 File Offset: 0x00088F15
		// (set) Token: 0x06003279 RID: 12921 RVA: 0x0008AD1D File Offset: 0x00088F1D
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

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x0600327A RID: 12922 RVA: 0x0008AD26 File Offset: 0x00088F26
		// (set) Token: 0x0600327B RID: 12923 RVA: 0x0008AD2E File Offset: 0x00088F2E
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

		// Token: 0x0600327C RID: 12924 RVA: 0x0008AD37 File Offset: 0x00088F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterStrongChallengeActivityStageScRsp);
		}

		// Token: 0x0600327D RID: 12925 RVA: 0x0008AD48 File Offset: 0x00088F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterStrongChallengeActivityStageScRsp other)
		{
			return other != null && (other == this || (this.StageId == other.StageId && this.Retcode == other.Retcode && object.Equals(this.BattleInfo, other.BattleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600327E RID: 12926 RVA: 0x0008ADA8 File Offset: 0x00088FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StageId != 0U)
			{
				num ^= this.StageId.GetHashCode();
			}
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

		// Token: 0x0600327F RID: 12927 RVA: 0x0008AE16 File Offset: 0x00089016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003280 RID: 12928 RVA: 0x0008AE1E File Offset: 0x0008901E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003281 RID: 12929 RVA: 0x0008AE28 File Offset: 0x00089028
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
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.StageId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.StageId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003282 RID: 12930 RVA: 0x0008AEA0 File Offset: 0x000890A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StageId);
			}
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

		// Token: 0x06003283 RID: 12931 RVA: 0x0008AF10 File Offset: 0x00089110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterStrongChallengeActivityStageScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StageId != 0U)
			{
				this.StageId = other.StageId;
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

		// Token: 0x06003284 RID: 12932 RVA: 0x0008AF8C File Offset: 0x0008918C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003285 RID: 12933 RVA: 0x0008AF98 File Offset: 0x00089198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 64U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.StageId = input.ReadUInt32();
						}
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

		// Token: 0x04001418 RID: 5144
		private static readonly MessageParser<EnterStrongChallengeActivityStageScRsp> _parser = new MessageParser<EnterStrongChallengeActivityStageScRsp>(() => new EnterStrongChallengeActivityStageScRsp());

		// Token: 0x04001419 RID: 5145
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400141A RID: 5146
		public const int StageIdFieldNumber = 12;

		// Token: 0x0400141B RID: 5147
		private uint stageId_;

		// Token: 0x0400141C RID: 5148
		public const int RetcodeFieldNumber = 8;

		// Token: 0x0400141D RID: 5149
		private uint retcode_;

		// Token: 0x0400141E RID: 5150
		public const int BattleInfoFieldNumber = 3;

		// Token: 0x0400141F RID: 5151
		private SceneBattleInfo battleInfo_;
	}
}
