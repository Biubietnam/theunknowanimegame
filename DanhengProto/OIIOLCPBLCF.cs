using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C53 RID: 3155
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OIIOLCPBLCF : IMessage<OIIOLCPBLCF>, IMessage, IEquatable<OIIOLCPBLCF>, IDeepCloneable<OIIOLCPBLCF>, IBufferMessage
	{
		// Token: 0x17002754 RID: 10068
		// (get) Token: 0x06008C0D RID: 35853 RVA: 0x001721A7 File Offset: 0x001703A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OIIOLCPBLCF> Parser
		{
			get
			{
				return OIIOLCPBLCF._parser;
			}
		}

		// Token: 0x17002755 RID: 10069
		// (get) Token: 0x06008C0E RID: 35854 RVA: 0x001721AE File Offset: 0x001703AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OIIOLCPBLCFReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002756 RID: 10070
		// (get) Token: 0x06008C0F RID: 35855 RVA: 0x001721C0 File Offset: 0x001703C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OIIOLCPBLCF.Descriptor;
			}
		}

		// Token: 0x06008C10 RID: 35856 RVA: 0x001721C7 File Offset: 0x001703C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OIIOLCPBLCF()
		{
		}

		// Token: 0x06008C11 RID: 35857 RVA: 0x001721D0 File Offset: 0x001703D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OIIOLCPBLCF(OIIOLCPBLCF other) : this()
		{
			this.raidId_ = other.raidId_;
			this.worldLevel_ = other.worldLevel_;
			this.lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
			this.pJHMGGGKCMK_ = ((other.pJHMGGGKCMK_ != null) ? other.pJHMGGGKCMK_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008C12 RID: 35858 RVA: 0x00172244 File Offset: 0x00170444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OIIOLCPBLCF Clone()
		{
			return new OIIOLCPBLCF(this);
		}

		// Token: 0x17002757 RID: 10071
		// (get) Token: 0x06008C13 RID: 35859 RVA: 0x0017224C File Offset: 0x0017044C
		// (set) Token: 0x06008C14 RID: 35860 RVA: 0x00172254 File Offset: 0x00170454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RaidId
		{
			get
			{
				return this.raidId_;
			}
			set
			{
				this.raidId_ = value;
			}
		}

		// Token: 0x17002758 RID: 10072
		// (get) Token: 0x06008C15 RID: 35861 RVA: 0x0017225D File Offset: 0x0017045D
		// (set) Token: 0x06008C16 RID: 35862 RVA: 0x00172265 File Offset: 0x00170465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint WorldLevel
		{
			get
			{
				return this.worldLevel_;
			}
			set
			{
				this.worldLevel_ = value;
			}
		}

		// Token: 0x17002759 RID: 10073
		// (get) Token: 0x06008C17 RID: 35863 RVA: 0x0017226E File Offset: 0x0017046E
		// (set) Token: 0x06008C18 RID: 35864 RVA: 0x00172276 File Offset: 0x00170476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineupInfo Lineup
		{
			get
			{
				return this.lineup_;
			}
			set
			{
				this.lineup_ = value;
			}
		}

		// Token: 0x1700275A RID: 10074
		// (get) Token: 0x06008C19 RID: 35865 RVA: 0x0017227F File Offset: 0x0017047F
		// (set) Token: 0x06008C1A RID: 35866 RVA: 0x00172287 File Offset: 0x00170487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneInfo PJHMGGGKCMK
		{
			get
			{
				return this.pJHMGGGKCMK_;
			}
			set
			{
				this.pJHMGGGKCMK_ = value;
			}
		}

		// Token: 0x06008C1B RID: 35867 RVA: 0x00172290 File Offset: 0x00170490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OIIOLCPBLCF);
		}

		// Token: 0x06008C1C RID: 35868 RVA: 0x001722A0 File Offset: 0x001704A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OIIOLCPBLCF other)
		{
			return other != null && (other == this || (this.RaidId == other.RaidId && this.WorldLevel == other.WorldLevel && object.Equals(this.Lineup, other.Lineup) && object.Equals(this.PJHMGGGKCMK, other.PJHMGGGKCMK) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008C1D RID: 35869 RVA: 0x00172314 File Offset: 0x00170514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RaidId != 0U)
			{
				num ^= this.RaidId.GetHashCode();
			}
			if (this.WorldLevel != 0U)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this.lineup_ != null)
			{
				num ^= this.Lineup.GetHashCode();
			}
			if (this.pJHMGGGKCMK_ != null)
			{
				num ^= this.PJHMGGGKCMK.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008C1E RID: 35870 RVA: 0x00172398 File Offset: 0x00170598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008C1F RID: 35871 RVA: 0x001723A0 File Offset: 0x001705A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008C20 RID: 35872 RVA: 0x001723AC File Offset: 0x001705AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pJHMGGGKCMK_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.PJHMGGGKCMK);
			}
			if (this.WorldLevel != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.WorldLevel);
			}
			if (this.lineup_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Lineup);
			}
			if (this.RaidId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.RaidId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008C21 RID: 35873 RVA: 0x00172440 File Offset: 0x00170640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RaidId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RaidId);
			}
			if (this.WorldLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorldLevel);
			}
			if (this.lineup_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Lineup);
			}
			if (this.pJHMGGGKCMK_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PJHMGGGKCMK);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008C22 RID: 35874 RVA: 0x001724C8 File Offset: 0x001706C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OIIOLCPBLCF other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RaidId != 0U)
			{
				this.RaidId = other.RaidId;
			}
			if (other.WorldLevel != 0U)
			{
				this.WorldLevel = other.WorldLevel;
			}
			if (other.lineup_ != null)
			{
				if (this.lineup_ == null)
				{
					this.Lineup = new LineupInfo();
				}
				this.Lineup.MergeFrom(other.Lineup);
			}
			if (other.pJHMGGGKCMK_ != null)
			{
				if (this.pJHMGGGKCMK_ == null)
				{
					this.PJHMGGGKCMK = new SceneInfo();
				}
				this.PJHMGGGKCMK.MergeFrom(other.PJHMGGGKCMK);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008C23 RID: 35875 RVA: 0x00172570 File Offset: 0x00170770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008C24 RID: 35876 RVA: 0x0017257C File Offset: 0x0017077C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 18U)
					{
						if (this.pJHMGGGKCMK_ == null)
						{
							this.PJHMGGGKCMK = new SceneInfo();
						}
						input.ReadMessage(this.PJHMGGGKCMK);
						continue;
					}
					if (num == 64U)
					{
						this.WorldLevel = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						if (this.lineup_ == null)
						{
							this.Lineup = new LineupInfo();
						}
						input.ReadMessage(this.Lineup);
						continue;
					}
					if (num == 96U)
					{
						this.RaidId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040035C3 RID: 13763
		private static readonly MessageParser<OIIOLCPBLCF> _parser = new MessageParser<OIIOLCPBLCF>(() => new OIIOLCPBLCF());

		// Token: 0x040035C4 RID: 13764
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035C5 RID: 13765
		public const int RaidIdFieldNumber = 12;

		// Token: 0x040035C6 RID: 13766
		private uint raidId_;

		// Token: 0x040035C7 RID: 13767
		public const int WorldLevelFieldNumber = 8;

		// Token: 0x040035C8 RID: 13768
		private uint worldLevel_;

		// Token: 0x040035C9 RID: 13769
		public const int LineupFieldNumber = 11;

		// Token: 0x040035CA RID: 13770
		private LineupInfo lineup_;

		// Token: 0x040035CB RID: 13771
		public const int PJHMGGGKCMKFieldNumber = 2;

		// Token: 0x040035CC RID: 13772
		private SceneInfo pJHMGGGKCMK_;
	}
}
