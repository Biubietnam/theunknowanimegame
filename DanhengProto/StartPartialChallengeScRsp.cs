using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011BB RID: 4539
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartPartialChallengeScRsp : IMessage<StartPartialChallengeScRsp>, IMessage, IEquatable<StartPartialChallengeScRsp>, IDeepCloneable<StartPartialChallengeScRsp>, IBufferMessage
	{
		// Token: 0x1700392B RID: 14635
		// (get) Token: 0x0600CAB8 RID: 51896 RVA: 0x0021FCF3 File Offset: 0x0021DEF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartPartialChallengeScRsp> Parser
		{
			get
			{
				return StartPartialChallengeScRsp._parser;
			}
		}

		// Token: 0x1700392C RID: 14636
		// (get) Token: 0x0600CAB9 RID: 51897 RVA: 0x0021FCFA File Offset: 0x0021DEFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartPartialChallengeScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700392D RID: 14637
		// (get) Token: 0x0600CABA RID: 51898 RVA: 0x0021FD0C File Offset: 0x0021DF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartPartialChallengeScRsp.Descriptor;
			}
		}

		// Token: 0x0600CABB RID: 51899 RVA: 0x0021FD13 File Offset: 0x0021DF13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartPartialChallengeScRsp()
		{
		}

		// Token: 0x0600CABC RID: 51900 RVA: 0x0021FD1C File Offset: 0x0021DF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartPartialChallengeScRsp(StartPartialChallengeScRsp other) : this()
		{
			this.lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
			this.scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.curChallenge_ = ((other.curChallenge_ != null) ? other.curChallenge_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CABD RID: 51901 RVA: 0x0021FDA0 File Offset: 0x0021DFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartPartialChallengeScRsp Clone()
		{
			return new StartPartialChallengeScRsp(this);
		}

		// Token: 0x1700392E RID: 14638
		// (get) Token: 0x0600CABE RID: 51902 RVA: 0x0021FDA8 File Offset: 0x0021DFA8
		// (set) Token: 0x0600CABF RID: 51903 RVA: 0x0021FDB0 File Offset: 0x0021DFB0
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

		// Token: 0x1700392F RID: 14639
		// (get) Token: 0x0600CAC0 RID: 51904 RVA: 0x0021FDB9 File Offset: 0x0021DFB9
		// (set) Token: 0x0600CAC1 RID: 51905 RVA: 0x0021FDC1 File Offset: 0x0021DFC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneInfo Scene
		{
			get
			{
				return this.scene_;
			}
			set
			{
				this.scene_ = value;
			}
		}

		// Token: 0x17003930 RID: 14640
		// (get) Token: 0x0600CAC2 RID: 51906 RVA: 0x0021FDCA File Offset: 0x0021DFCA
		// (set) Token: 0x0600CAC3 RID: 51907 RVA: 0x0021FDD2 File Offset: 0x0021DFD2
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

		// Token: 0x17003931 RID: 14641
		// (get) Token: 0x0600CAC4 RID: 51908 RVA: 0x0021FDDB File Offset: 0x0021DFDB
		// (set) Token: 0x0600CAC5 RID: 51909 RVA: 0x0021FDE3 File Offset: 0x0021DFE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CurChallenge CurChallenge
		{
			get
			{
				return this.curChallenge_;
			}
			set
			{
				this.curChallenge_ = value;
			}
		}

		// Token: 0x0600CAC6 RID: 51910 RVA: 0x0021FDEC File Offset: 0x0021DFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartPartialChallengeScRsp);
		}

		// Token: 0x0600CAC7 RID: 51911 RVA: 0x0021FDFC File Offset: 0x0021DFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartPartialChallengeScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Lineup, other.Lineup) && object.Equals(this.Scene, other.Scene) && this.Retcode == other.Retcode && object.Equals(this.CurChallenge, other.CurChallenge) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CAC8 RID: 51912 RVA: 0x0021FE74 File Offset: 0x0021E074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.lineup_ != null)
			{
				num ^= this.Lineup.GetHashCode();
			}
			if (this.scene_ != null)
			{
				num ^= this.Scene.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.curChallenge_ != null)
			{
				num ^= this.CurChallenge.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CAC9 RID: 51913 RVA: 0x0021FEF5 File Offset: 0x0021E0F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CACA RID: 51914 RVA: 0x0021FEFD File Offset: 0x0021E0FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CACB RID: 51915 RVA: 0x0021FF08 File Offset: 0x0021E108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.scene_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Scene);
			}
			if (this.lineup_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Lineup);
			}
			if (this.curChallenge_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.CurChallenge);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CACC RID: 51916 RVA: 0x0021FF9C File Offset: 0x0021E19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.lineup_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Lineup);
			}
			if (this.scene_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Scene);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.curChallenge_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurChallenge);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CACD RID: 51917 RVA: 0x00220024 File Offset: 0x0021E224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartPartialChallengeScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.lineup_ != null)
			{
				if (this.lineup_ == null)
				{
					this.Lineup = new LineupInfo();
				}
				this.Lineup.MergeFrom(other.Lineup);
			}
			if (other.scene_ != null)
			{
				if (this.scene_ == null)
				{
					this.Scene = new SceneInfo();
				}
				this.Scene.MergeFrom(other.Scene);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.curChallenge_ != null)
			{
				if (this.curChallenge_ == null)
				{
					this.CurChallenge = new CurChallenge();
				}
				this.CurChallenge.MergeFrom(other.CurChallenge);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CACE RID: 51918 RVA: 0x002200E4 File Offset: 0x0021E2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CACF RID: 51919 RVA: 0x002200F0 File Offset: 0x0021E2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 74U)
				{
					if (num == 64U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 74U)
					{
						if (this.scene_ == null)
						{
							this.Scene = new SceneInfo();
						}
						input.ReadMessage(this.Scene);
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						if (this.lineup_ == null)
						{
							this.Lineup = new LineupInfo();
						}
						input.ReadMessage(this.Lineup);
						continue;
					}
					if (num == 90U)
					{
						if (this.curChallenge_ == null)
						{
							this.CurChallenge = new CurChallenge();
						}
						input.ReadMessage(this.CurChallenge);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040051BE RID: 20926
		private static readonly MessageParser<StartPartialChallengeScRsp> _parser = new MessageParser<StartPartialChallengeScRsp>(() => new StartPartialChallengeScRsp());

		// Token: 0x040051BF RID: 20927
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051C0 RID: 20928
		public const int LineupFieldNumber = 10;

		// Token: 0x040051C1 RID: 20929
		private LineupInfo lineup_;

		// Token: 0x040051C2 RID: 20930
		public const int SceneFieldNumber = 9;

		// Token: 0x040051C3 RID: 20931
		private SceneInfo scene_;

		// Token: 0x040051C4 RID: 20932
		public const int RetcodeFieldNumber = 8;

		// Token: 0x040051C5 RID: 20933
		private uint retcode_;

		// Token: 0x040051C6 RID: 20934
		public const int CurChallengeFieldNumber = 11;

		// Token: 0x040051C7 RID: 20935
		private CurChallenge curChallenge_;
	}
}
