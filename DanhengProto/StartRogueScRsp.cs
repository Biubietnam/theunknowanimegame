using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011C7 RID: 4551
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartRogueScRsp : IMessage<StartRogueScRsp>, IMessage, IEquatable<StartRogueScRsp>, IDeepCloneable<StartRogueScRsp>, IBufferMessage
	{
		// Token: 0x1700395D RID: 14685
		// (get) Token: 0x0600CB59 RID: 52057 RVA: 0x00221C83 File Offset: 0x0021FE83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartRogueScRsp> Parser
		{
			get
			{
				return StartRogueScRsp._parser;
			}
		}

		// Token: 0x1700395E RID: 14686
		// (get) Token: 0x0600CB5A RID: 52058 RVA: 0x00221C8A File Offset: 0x0021FE8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartRogueScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700395F RID: 14687
		// (get) Token: 0x0600CB5B RID: 52059 RVA: 0x00221C9C File Offset: 0x0021FE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartRogueScRsp.Descriptor;
			}
		}

		// Token: 0x0600CB5C RID: 52060 RVA: 0x00221CA3 File Offset: 0x0021FEA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartRogueScRsp()
		{
		}

		// Token: 0x0600CB5D RID: 52061 RVA: 0x00221CAC File Offset: 0x0021FEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartRogueScRsp(StartRogueScRsp other) : this()
		{
			this.lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
			this.rotateInfo_ = ((other.rotateInfo_ != null) ? other.rotateInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
			this.rogueGameInfo_ = ((other.rogueGameInfo_ != null) ? other.rogueGameInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CB5E RID: 52062 RVA: 0x00221D4C File Offset: 0x0021FF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartRogueScRsp Clone()
		{
			return new StartRogueScRsp(this);
		}

		// Token: 0x17003960 RID: 14688
		// (get) Token: 0x0600CB5F RID: 52063 RVA: 0x00221D54 File Offset: 0x0021FF54
		// (set) Token: 0x0600CB60 RID: 52064 RVA: 0x00221D5C File Offset: 0x0021FF5C
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

		// Token: 0x17003961 RID: 14689
		// (get) Token: 0x0600CB61 RID: 52065 RVA: 0x00221D65 File Offset: 0x0021FF65
		// (set) Token: 0x0600CB62 RID: 52066 RVA: 0x00221D6D File Offset: 0x0021FF6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMapRotateInfo RotateInfo
		{
			get
			{
				return this.rotateInfo_;
			}
			set
			{
				this.rotateInfo_ = value;
			}
		}

		// Token: 0x17003962 RID: 14690
		// (get) Token: 0x0600CB63 RID: 52067 RVA: 0x00221D76 File Offset: 0x0021FF76
		// (set) Token: 0x0600CB64 RID: 52068 RVA: 0x00221D7E File Offset: 0x0021FF7E
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

		// Token: 0x17003963 RID: 14691
		// (get) Token: 0x0600CB65 RID: 52069 RVA: 0x00221D87 File Offset: 0x0021FF87
		// (set) Token: 0x0600CB66 RID: 52070 RVA: 0x00221D8F File Offset: 0x0021FF8F
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

		// Token: 0x17003964 RID: 14692
		// (get) Token: 0x0600CB67 RID: 52071 RVA: 0x00221D98 File Offset: 0x0021FF98
		// (set) Token: 0x0600CB68 RID: 52072 RVA: 0x00221DA0 File Offset: 0x0021FFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInfo RogueGameInfo
		{
			get
			{
				return this.rogueGameInfo_;
			}
			set
			{
				this.rogueGameInfo_ = value;
			}
		}

		// Token: 0x0600CB69 RID: 52073 RVA: 0x00221DA9 File Offset: 0x0021FFA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartRogueScRsp);
		}

		// Token: 0x0600CB6A RID: 52074 RVA: 0x00221DB8 File Offset: 0x0021FFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartRogueScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Lineup, other.Lineup) && object.Equals(this.RotateInfo, other.RotateInfo) && this.Retcode == other.Retcode && object.Equals(this.Scene, other.Scene) && object.Equals(this.RogueGameInfo, other.RogueGameInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CB6B RID: 52075 RVA: 0x00221E48 File Offset: 0x00220048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.lineup_ != null)
			{
				num ^= this.Lineup.GetHashCode();
			}
			if (this.rotateInfo_ != null)
			{
				num ^= this.RotateInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.scene_ != null)
			{
				num ^= this.Scene.GetHashCode();
			}
			if (this.rogueGameInfo_ != null)
			{
				num ^= this.RogueGameInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CB6C RID: 52076 RVA: 0x00221EDF File Offset: 0x002200DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CB6D RID: 52077 RVA: 0x00221EE7 File Offset: 0x002200E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CB6E RID: 52078 RVA: 0x00221EF0 File Offset: 0x002200F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this.scene_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Scene);
			}
			if (this.lineup_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Lineup);
			}
			if (this.rotateInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.RotateInfo);
			}
			if (this.rogueGameInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.RogueGameInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CB6F RID: 52079 RVA: 0x00221FA0 File Offset: 0x002201A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.lineup_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Lineup);
			}
			if (this.rotateInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RotateInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.scene_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Scene);
			}
			if (this.rogueGameInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueGameInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CB70 RID: 52080 RVA: 0x00222040 File Offset: 0x00220240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartRogueScRsp other)
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
			if (other.rotateInfo_ != null)
			{
				if (this.rotateInfo_ == null)
				{
					this.RotateInfo = new RogueMapRotateInfo();
				}
				this.RotateInfo.MergeFrom(other.RotateInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.scene_ != null)
			{
				if (this.scene_ == null)
				{
					this.Scene = new SceneInfo();
				}
				this.Scene.MergeFrom(other.Scene);
			}
			if (other.rogueGameInfo_ != null)
			{
				if (this.rogueGameInfo_ == null)
				{
					this.RogueGameInfo = new RogueInfo();
				}
				this.RogueGameInfo.MergeFrom(other.RogueGameInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CB71 RID: 52081 RVA: 0x0022212C File Offset: 0x0022032C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CB72 RID: 52082 RVA: 0x00222138 File Offset: 0x00220338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num == 32U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 50U)
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
					if (num == 90U)
					{
						if (this.lineup_ == null)
						{
							this.Lineup = new LineupInfo();
						}
						input.ReadMessage(this.Lineup);
						continue;
					}
					if (num == 114U)
					{
						if (this.rotateInfo_ == null)
						{
							this.RotateInfo = new RogueMapRotateInfo();
						}
						input.ReadMessage(this.RotateInfo);
						continue;
					}
					if (num == 122U)
					{
						if (this.rogueGameInfo_ == null)
						{
							this.RogueGameInfo = new RogueInfo();
						}
						input.ReadMessage(this.RogueGameInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005209 RID: 21001
		private static readonly MessageParser<StartRogueScRsp> _parser = new MessageParser<StartRogueScRsp>(() => new StartRogueScRsp());

		// Token: 0x0400520A RID: 21002
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400520B RID: 21003
		public const int LineupFieldNumber = 11;

		// Token: 0x0400520C RID: 21004
		private LineupInfo lineup_;

		// Token: 0x0400520D RID: 21005
		public const int RotateInfoFieldNumber = 14;

		// Token: 0x0400520E RID: 21006
		private RogueMapRotateInfo rotateInfo_;

		// Token: 0x0400520F RID: 21007
		public const int RetcodeFieldNumber = 4;

		// Token: 0x04005210 RID: 21008
		private uint retcode_;

		// Token: 0x04005211 RID: 21009
		public const int SceneFieldNumber = 6;

		// Token: 0x04005212 RID: 21010
		private SceneInfo scene_;

		// Token: 0x04005213 RID: 21011
		public const int RogueGameInfoFieldNumber = 15;

		// Token: 0x04005214 RID: 21012
		private RogueInfo rogueGameInfo_;
	}
}
