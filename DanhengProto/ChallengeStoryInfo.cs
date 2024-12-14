using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001C1 RID: 449
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeStoryInfo : IMessage<ChallengeStoryInfo>, IMessage, IEquatable<ChallengeStoryInfo>, IDeepCloneable<ChallengeStoryInfo>, IBufferMessage
	{
		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x00039F5F File Offset: 0x0003815F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeStoryInfo> Parser
		{
			get
			{
				return ChallengeStoryInfo._parser;
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x00039F66 File Offset: 0x00038166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeStoryInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x0600142B RID: 5163 RVA: 0x00039F78 File Offset: 0x00038178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeStoryInfo.Descriptor;
			}
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x00039F7F File Offset: 0x0003817F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStoryInfo()
		{
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x00039F88 File Offset: 0x00038188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStoryInfo(ChallengeStoryInfo other) : this()
		{
			this.curStoryBuffs_ = ((other.curStoryBuffs_ != null) ? other.curStoryBuffs_.Clone() : null);
			this.curBossBuffs_ = ((other.curBossBuffs_ != null) ? other.curBossBuffs_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x00039FE4 File Offset: 0x000381E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStoryInfo Clone()
		{
			return new ChallengeStoryInfo(this);
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x0600142F RID: 5167 RVA: 0x00039FEC File Offset: 0x000381EC
		// (set) Token: 0x06001430 RID: 5168 RVA: 0x00039FF4 File Offset: 0x000381F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStoryBuffList CurStoryBuffs
		{
			get
			{
				return this.curStoryBuffs_;
			}
			set
			{
				this.curStoryBuffs_ = value;
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001431 RID: 5169 RVA: 0x00039FFD File Offset: 0x000381FD
		// (set) Token: 0x06001432 RID: 5170 RVA: 0x0003A005 File Offset: 0x00038205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossBuffList CurBossBuffs
		{
			get
			{
				return this.curBossBuffs_;
			}
			set
			{
				this.curBossBuffs_ = value;
			}
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x0003A00E File Offset: 0x0003820E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeStoryInfo);
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x0003A01C File Offset: 0x0003821C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeStoryInfo other)
		{
			return other != null && (other == this || (object.Equals(this.CurStoryBuffs, other.CurStoryBuffs) && object.Equals(this.CurBossBuffs, other.CurBossBuffs) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x0003A070 File Offset: 0x00038270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.curStoryBuffs_ != null)
			{
				num ^= this.CurStoryBuffs.GetHashCode();
			}
			if (this.curBossBuffs_ != null)
			{
				num ^= this.CurBossBuffs.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x0003A0C2 File Offset: 0x000382C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x0003A0CA File Offset: 0x000382CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x0003A0D4 File Offset: 0x000382D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.curBossBuffs_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.CurBossBuffs);
			}
			if (this.curStoryBuffs_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.CurStoryBuffs);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x0003A130 File Offset: 0x00038330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.curStoryBuffs_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurStoryBuffs);
			}
			if (this.curBossBuffs_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurBossBuffs);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x0003A188 File Offset: 0x00038388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeStoryInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.curStoryBuffs_ != null)
			{
				if (this.curStoryBuffs_ == null)
				{
					this.CurStoryBuffs = new ChallengeStoryBuffList();
				}
				this.CurStoryBuffs.MergeFrom(other.CurStoryBuffs);
			}
			if (other.curBossBuffs_ != null)
			{
				if (this.curBossBuffs_ == null)
				{
					this.CurBossBuffs = new ChallengeBossBuffList();
				}
				this.CurBossBuffs.MergeFrom(other.CurBossBuffs);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x0003A208 File Offset: 0x00038408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x0003A214 File Offset: 0x00038414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 90U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.curStoryBuffs_ == null)
						{
							this.CurStoryBuffs = new ChallengeStoryBuffList();
						}
						input.ReadMessage(this.CurStoryBuffs);
					}
				}
				else
				{
					if (this.curBossBuffs_ == null)
					{
						this.CurBossBuffs = new ChallengeBossBuffList();
					}
					input.ReadMessage(this.CurBossBuffs);
				}
			}
		}

		// Token: 0x04000878 RID: 2168
		private static readonly MessageParser<ChallengeStoryInfo> _parser = new MessageParser<ChallengeStoryInfo>(() => new ChallengeStoryInfo());

		// Token: 0x04000879 RID: 2169
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400087A RID: 2170
		public const int CurStoryBuffsFieldNumber = 14;

		// Token: 0x0400087B RID: 2171
		private ChallengeStoryBuffList curStoryBuffs_;

		// Token: 0x0400087C RID: 2172
		public const int CurBossBuffsFieldNumber = 11;

		// Token: 0x0400087D RID: 2173
		private ChallengeBossBuffList curBossBuffs_;
	}
}
