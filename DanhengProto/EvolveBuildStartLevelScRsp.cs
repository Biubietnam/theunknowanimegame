using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004C7 RID: 1223
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildStartLevelScRsp : IMessage<EvolveBuildStartLevelScRsp>, IMessage, IEquatable<EvolveBuildStartLevelScRsp>, IDeepCloneable<EvolveBuildStartLevelScRsp>, IBufferMessage
	{
		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x060036AC RID: 13996 RVA: 0x00096443 File Offset: 0x00094643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildStartLevelScRsp> Parser
		{
			get
			{
				return EvolveBuildStartLevelScRsp._parser;
			}
		}

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x060036AD RID: 13997 RVA: 0x0009644A File Offset: 0x0009464A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildStartLevelScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x060036AE RID: 13998 RVA: 0x0009645C File Offset: 0x0009465C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildStartLevelScRsp.Descriptor;
			}
		}

		// Token: 0x060036AF RID: 13999 RVA: 0x00096463 File Offset: 0x00094663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildStartLevelScRsp()
		{
		}

		// Token: 0x060036B0 RID: 14000 RVA: 0x0009646C File Offset: 0x0009466C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildStartLevelScRsp(EvolveBuildStartLevelScRsp other) : this()
		{
			this.levelInfo_ = ((other.levelInfo_ != null) ? other.levelInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.kFPDPBBAOPL_ = ((other.kFPDPBBAOPL_ != null) ? other.kFPDPBBAOPL_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060036B1 RID: 14001 RVA: 0x000964D4 File Offset: 0x000946D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildStartLevelScRsp Clone()
		{
			return new EvolveBuildStartLevelScRsp(this);
		}

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x060036B2 RID: 14002 RVA: 0x000964DC File Offset: 0x000946DC
		// (set) Token: 0x060036B3 RID: 14003 RVA: 0x000964E4 File Offset: 0x000946E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildLevelInfo LevelInfo
		{
			get
			{
				return this.levelInfo_;
			}
			set
			{
				this.levelInfo_ = value;
			}
		}

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x060036B4 RID: 14004 RVA: 0x000964ED File Offset: 0x000946ED
		// (set) Token: 0x060036B5 RID: 14005 RVA: 0x000964F5 File Offset: 0x000946F5
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

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x060036B6 RID: 14006 RVA: 0x000964FE File Offset: 0x000946FE
		// (set) Token: 0x060036B7 RID: 14007 RVA: 0x00096506 File Offset: 0x00094706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBattleInfo KFPDPBBAOPL
		{
			get
			{
				return this.kFPDPBBAOPL_;
			}
			set
			{
				this.kFPDPBBAOPL_ = value;
			}
		}

		// Token: 0x060036B8 RID: 14008 RVA: 0x0009650F File Offset: 0x0009470F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildStartLevelScRsp);
		}

		// Token: 0x060036B9 RID: 14009 RVA: 0x00096520 File Offset: 0x00094720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildStartLevelScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.LevelInfo, other.LevelInfo) && this.Retcode == other.Retcode && object.Equals(this.KFPDPBBAOPL, other.KFPDPBBAOPL) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060036BA RID: 14010 RVA: 0x00096584 File Offset: 0x00094784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.levelInfo_ != null)
			{
				num ^= this.LevelInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.kFPDPBBAOPL_ != null)
			{
				num ^= this.KFPDPBBAOPL.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x000965EF File Offset: 0x000947EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x000965F7 File Offset: 0x000947F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060036BD RID: 14013 RVA: 0x00096600 File Offset: 0x00094800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.kFPDPBBAOPL_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.KFPDPBBAOPL);
			}
			if (this.levelInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.LevelInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060036BE RID: 14014 RVA: 0x00096678 File Offset: 0x00094878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.levelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LevelInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.kFPDPBBAOPL_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KFPDPBBAOPL);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x000966E8 File Offset: 0x000948E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildStartLevelScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.levelInfo_ != null)
			{
				if (this.levelInfo_ == null)
				{
					this.LevelInfo = new EvolveBuildLevelInfo();
				}
				this.LevelInfo.MergeFrom(other.LevelInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.kFPDPBBAOPL_ != null)
			{
				if (this.kFPDPBBAOPL_ == null)
				{
					this.KFPDPBBAOPL = new SceneBattleInfo();
				}
				this.KFPDPBBAOPL.MergeFrom(other.KFPDPBBAOPL);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060036C0 RID: 14016 RVA: 0x0009677C File Offset: 0x0009497C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060036C1 RID: 14017 RVA: 0x00096788 File Offset: 0x00094988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 50U)
					{
						if (num != 98U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.levelInfo_ == null)
							{
								this.LevelInfo = new EvolveBuildLevelInfo();
							}
							input.ReadMessage(this.LevelInfo);
						}
					}
					else
					{
						if (this.kFPDPBBAOPL_ == null)
						{
							this.KFPDPBBAOPL = new SceneBattleInfo();
						}
						input.ReadMessage(this.KFPDPBBAOPL);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040015BB RID: 5563
		private static readonly MessageParser<EvolveBuildStartLevelScRsp> _parser = new MessageParser<EvolveBuildStartLevelScRsp>(() => new EvolveBuildStartLevelScRsp());

		// Token: 0x040015BC RID: 5564
		private UnknownFieldSet _unknownFields;

		// Token: 0x040015BD RID: 5565
		public const int LevelInfoFieldNumber = 12;

		// Token: 0x040015BE RID: 5566
		private EvolveBuildLevelInfo levelInfo_;

		// Token: 0x040015BF RID: 5567
		public const int RetcodeFieldNumber = 5;

		// Token: 0x040015C0 RID: 5568
		private uint retcode_;

		// Token: 0x040015C1 RID: 5569
		public const int KFPDPBBAOPLFieldNumber = 6;

		// Token: 0x040015C2 RID: 5570
		private SceneBattleInfo kFPDPBBAOPL_;
	}
}
