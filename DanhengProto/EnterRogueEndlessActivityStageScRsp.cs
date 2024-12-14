using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000457 RID: 1111
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterRogueEndlessActivityStageScRsp : IMessage<EnterRogueEndlessActivityStageScRsp>, IMessage, IEquatable<EnterRogueEndlessActivityStageScRsp>, IDeepCloneable<EnterRogueEndlessActivityStageScRsp>, IBufferMessage
	{
		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x06003170 RID: 12656 RVA: 0x00087EBF File Offset: 0x000860BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterRogueEndlessActivityStageScRsp> Parser
		{
			get
			{
				return EnterRogueEndlessActivityStageScRsp._parser;
			}
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06003171 RID: 12657 RVA: 0x00087EC6 File Offset: 0x000860C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterRogueEndlessActivityStageScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06003172 RID: 12658 RVA: 0x00087ED8 File Offset: 0x000860D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterRogueEndlessActivityStageScRsp.Descriptor;
			}
		}

		// Token: 0x06003173 RID: 12659 RVA: 0x00087EDF File Offset: 0x000860DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterRogueEndlessActivityStageScRsp()
		{
		}

		// Token: 0x06003174 RID: 12660 RVA: 0x00087EE8 File Offset: 0x000860E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterRogueEndlessActivityStageScRsp(EnterRogueEndlessActivityStageScRsp other) : this()
		{
			this.hCMHGKIJKFI_ = ((other.hCMHGKIJKFI_ != null) ? other.hCMHGKIJKFI_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003175 RID: 12661 RVA: 0x00087F50 File Offset: 0x00086150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterRogueEndlessActivityStageScRsp Clone()
		{
			return new EnterRogueEndlessActivityStageScRsp(this);
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06003176 RID: 12662 RVA: 0x00087F58 File Offset: 0x00086158
		// (set) Token: 0x06003177 RID: 12663 RVA: 0x00087F60 File Offset: 0x00086160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueEndlessLayerInfo HCMHGKIJKFI
		{
			get
			{
				return this.hCMHGKIJKFI_;
			}
			set
			{
				this.hCMHGKIJKFI_ = value;
			}
		}

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06003178 RID: 12664 RVA: 0x00087F69 File Offset: 0x00086169
		// (set) Token: 0x06003179 RID: 12665 RVA: 0x00087F71 File Offset: 0x00086171
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

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x0600317A RID: 12666 RVA: 0x00087F7A File Offset: 0x0008617A
		// (set) Token: 0x0600317B RID: 12667 RVA: 0x00087F82 File Offset: 0x00086182
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

		// Token: 0x0600317C RID: 12668 RVA: 0x00087F8B File Offset: 0x0008618B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterRogueEndlessActivityStageScRsp);
		}

		// Token: 0x0600317D RID: 12669 RVA: 0x00087F9C File Offset: 0x0008619C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterRogueEndlessActivityStageScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.HCMHGKIJKFI, other.HCMHGKIJKFI) && this.Retcode == other.Retcode && object.Equals(this.BattleInfo, other.BattleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600317E RID: 12670 RVA: 0x00088000 File Offset: 0x00086200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.hCMHGKIJKFI_ != null)
			{
				num ^= this.HCMHGKIJKFI.GetHashCode();
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

		// Token: 0x0600317F RID: 12671 RVA: 0x0008806B File Offset: 0x0008626B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003180 RID: 12672 RVA: 0x00088073 File Offset: 0x00086273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x0008807C File Offset: 0x0008627C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this.hCMHGKIJKFI_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.HCMHGKIJKFI);
			}
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.BattleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003182 RID: 12674 RVA: 0x000880F4 File Offset: 0x000862F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.hCMHGKIJKFI_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HCMHGKIJKFI);
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

		// Token: 0x06003183 RID: 12675 RVA: 0x00088164 File Offset: 0x00086364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterRogueEndlessActivityStageScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.hCMHGKIJKFI_ != null)
			{
				if (this.hCMHGKIJKFI_ == null)
				{
					this.HCMHGKIJKFI = new RogueEndlessLayerInfo();
				}
				this.HCMHGKIJKFI.MergeFrom(other.HCMHGKIJKFI);
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

		// Token: 0x06003184 RID: 12676 RVA: 0x000881F8 File Offset: 0x000863F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003185 RID: 12677 RVA: 0x00088204 File Offset: 0x00086404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 50U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
					else
					{
						if (this.hCMHGKIJKFI_ == null)
						{
							this.HCMHGKIJKFI = new RogueEndlessLayerInfo();
						}
						input.ReadMessage(this.HCMHGKIJKFI);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040013AF RID: 5039
		private static readonly MessageParser<EnterRogueEndlessActivityStageScRsp> _parser = new MessageParser<EnterRogueEndlessActivityStageScRsp>(() => new EnterRogueEndlessActivityStageScRsp());

		// Token: 0x040013B0 RID: 5040
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013B1 RID: 5041
		public const int HCMHGKIJKFIFieldNumber = 6;

		// Token: 0x040013B2 RID: 5042
		private RogueEndlessLayerInfo hCMHGKIJKFI_;

		// Token: 0x040013B3 RID: 5043
		public const int RetcodeFieldNumber = 4;

		// Token: 0x040013B4 RID: 5044
		private uint retcode_;

		// Token: 0x040013B5 RID: 5045
		public const int BattleInfoFieldNumber = 13;

		// Token: 0x040013B6 RID: 5046
		private SceneBattleInfo battleInfo_;
	}
}
