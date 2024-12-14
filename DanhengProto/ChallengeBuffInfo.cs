using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001A5 RID: 421
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeBuffInfo : IMessage<ChallengeBuffInfo>, IMessage, IEquatable<ChallengeBuffInfo>, IDeepCloneable<ChallengeBuffInfo>, IBufferMessage
	{
		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x060012F4 RID: 4852 RVA: 0x00036E3B File Offset: 0x0003503B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeBuffInfo> Parser
		{
			get
			{
				return ChallengeBuffInfo._parser;
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x00036E42 File Offset: 0x00035042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeBuffInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x060012F6 RID: 4854 RVA: 0x00036E54 File Offset: 0x00035054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeBuffInfo.Descriptor;
			}
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x00036E5B File Offset: 0x0003505B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBuffInfo()
		{
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x00036E64 File Offset: 0x00035064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBuffInfo(ChallengeBuffInfo other) : this()
		{
			this.storyInfo_ = ((other.storyInfo_ != null) ? other.storyInfo_.Clone() : null);
			this.bossInfo_ = ((other.bossInfo_ != null) ? other.bossInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x00036EC0 File Offset: 0x000350C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBuffInfo Clone()
		{
			return new ChallengeBuffInfo(this);
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x060012FA RID: 4858 RVA: 0x00036EC8 File Offset: 0x000350C8
		// (set) Token: 0x060012FB RID: 4859 RVA: 0x00036ED0 File Offset: 0x000350D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStoryBuffInfo StoryInfo
		{
			get
			{
				return this.storyInfo_;
			}
			set
			{
				this.storyInfo_ = value;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x060012FC RID: 4860 RVA: 0x00036ED9 File Offset: 0x000350D9
		// (set) Token: 0x060012FD RID: 4861 RVA: 0x00036EE1 File Offset: 0x000350E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossBuffInfo BossInfo
		{
			get
			{
				return this.bossInfo_;
			}
			set
			{
				this.bossInfo_ = value;
			}
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x00036EEA File Offset: 0x000350EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeBuffInfo);
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x00036EF8 File Offset: 0x000350F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeBuffInfo other)
		{
			return other != null && (other == this || (object.Equals(this.StoryInfo, other.StoryInfo) && object.Equals(this.BossInfo, other.BossInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x00036F4C File Offset: 0x0003514C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.storyInfo_ != null)
			{
				num ^= this.StoryInfo.GetHashCode();
			}
			if (this.bossInfo_ != null)
			{
				num ^= this.BossInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x00036F9E File Offset: 0x0003519E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x00036FA6 File Offset: 0x000351A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x00036FB0 File Offset: 0x000351B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.bossInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.BossInfo);
			}
			if (this.storyInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.StoryInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x0003700C File Offset: 0x0003520C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.storyInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StoryInfo);
			}
			if (this.bossInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BossInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x00037064 File Offset: 0x00035264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeBuffInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.storyInfo_ != null)
			{
				if (this.storyInfo_ == null)
				{
					this.StoryInfo = new ChallengeStoryBuffInfo();
				}
				this.StoryInfo.MergeFrom(other.StoryInfo);
			}
			if (other.bossInfo_ != null)
			{
				if (this.bossInfo_ == null)
				{
					this.BossInfo = new ChallengeBossBuffInfo();
				}
				this.BossInfo.MergeFrom(other.BossInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x000370E4 File Offset: 0x000352E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x000370F0 File Offset: 0x000352F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 34U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.storyInfo_ == null)
						{
							this.StoryInfo = new ChallengeStoryBuffInfo();
						}
						input.ReadMessage(this.StoryInfo);
					}
				}
				else
				{
					if (this.bossInfo_ == null)
					{
						this.BossInfo = new ChallengeBossBuffInfo();
					}
					input.ReadMessage(this.BossInfo);
				}
			}
		}

		// Token: 0x04000807 RID: 2055
		private static readonly MessageParser<ChallengeBuffInfo> _parser = new MessageParser<ChallengeBuffInfo>(() => new ChallengeBuffInfo());

		// Token: 0x04000808 RID: 2056
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000809 RID: 2057
		public const int StoryInfoFieldNumber = 4;

		// Token: 0x0400080A RID: 2058
		private ChallengeStoryBuffInfo storyInfo_;

		// Token: 0x0400080B RID: 2059
		public const int BossInfoFieldNumber = 3;

		// Token: 0x0400080C RID: 2060
		private ChallengeBossBuffInfo bossInfo_;
	}
}
