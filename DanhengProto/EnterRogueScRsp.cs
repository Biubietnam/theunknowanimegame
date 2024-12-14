using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200045D RID: 1117
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterRogueScRsp : IMessage<EnterRogueScRsp>, IMessage, IEquatable<EnterRogueScRsp>, IDeepCloneable<EnterRogueScRsp>, IBufferMessage
	{
		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x060031BD RID: 12733 RVA: 0x00088D17 File Offset: 0x00086F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterRogueScRsp> Parser
		{
			get
			{
				return EnterRogueScRsp._parser;
			}
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x060031BE RID: 12734 RVA: 0x00088D1E File Offset: 0x00086F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterRogueScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x060031BF RID: 12735 RVA: 0x00088D30 File Offset: 0x00086F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterRogueScRsp.Descriptor;
			}
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x00088D37 File Offset: 0x00086F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterRogueScRsp()
		{
		}

		// Token: 0x060031C1 RID: 12737 RVA: 0x00088D40 File Offset: 0x00086F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterRogueScRsp(EnterRogueScRsp other) : this()
		{
			this.rotateInfo_ = ((other.rotateInfo_ != null) ? other.rotateInfo_.Clone() : null);
			this.lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
			this.rogueGameInfo_ = ((other.rogueGameInfo_ != null) ? other.rogueGameInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060031C2 RID: 12738 RVA: 0x00088DE0 File Offset: 0x00086FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterRogueScRsp Clone()
		{
			return new EnterRogueScRsp(this);
		}

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x060031C3 RID: 12739 RVA: 0x00088DE8 File Offset: 0x00086FE8
		// (set) Token: 0x060031C4 RID: 12740 RVA: 0x00088DF0 File Offset: 0x00086FF0
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

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x060031C5 RID: 12741 RVA: 0x00088DF9 File Offset: 0x00086FF9
		// (set) Token: 0x060031C6 RID: 12742 RVA: 0x00088E01 File Offset: 0x00087001
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

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x060031C7 RID: 12743 RVA: 0x00088E0A File Offset: 0x0008700A
		// (set) Token: 0x060031C8 RID: 12744 RVA: 0x00088E12 File Offset: 0x00087012
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

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x060031C9 RID: 12745 RVA: 0x00088E1B File Offset: 0x0008701B
		// (set) Token: 0x060031CA RID: 12746 RVA: 0x00088E23 File Offset: 0x00087023
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

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x060031CB RID: 12747 RVA: 0x00088E2C File Offset: 0x0008702C
		// (set) Token: 0x060031CC RID: 12748 RVA: 0x00088E34 File Offset: 0x00087034
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

		// Token: 0x060031CD RID: 12749 RVA: 0x00088E3D File Offset: 0x0008703D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterRogueScRsp);
		}

		// Token: 0x060031CE RID: 12750 RVA: 0x00088E4C File Offset: 0x0008704C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterRogueScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.RotateInfo, other.RotateInfo) && object.Equals(this.Lineup, other.Lineup) && object.Equals(this.RogueGameInfo, other.RogueGameInfo) && this.Retcode == other.Retcode && object.Equals(this.Scene, other.Scene) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060031CF RID: 12751 RVA: 0x00088EDC File Offset: 0x000870DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rotateInfo_ != null)
			{
				num ^= this.RotateInfo.GetHashCode();
			}
			if (this.lineup_ != null)
			{
				num ^= this.Lineup.GetHashCode();
			}
			if (this.rogueGameInfo_ != null)
			{
				num ^= this.RogueGameInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.scene_ != null)
			{
				num ^= this.Scene.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060031D0 RID: 12752 RVA: 0x00088F73 File Offset: 0x00087173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060031D1 RID: 12753 RVA: 0x00088F7B File Offset: 0x0008717B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060031D2 RID: 12754 RVA: 0x00088F84 File Offset: 0x00087184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.scene_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Scene);
			}
			if (this.rogueGameInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RogueGameInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this.lineup_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Lineup);
			}
			if (this.rotateInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.RotateInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060031D3 RID: 12755 RVA: 0x00089034 File Offset: 0x00087234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rotateInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RotateInfo);
			}
			if (this.lineup_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Lineup);
			}
			if (this.rogueGameInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueGameInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.scene_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Scene);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060031D4 RID: 12756 RVA: 0x000890D4 File Offset: 0x000872D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterRogueScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rotateInfo_ != null)
			{
				if (this.rotateInfo_ == null)
				{
					this.RotateInfo = new RogueMapRotateInfo();
				}
				this.RotateInfo.MergeFrom(other.RotateInfo);
			}
			if (other.lineup_ != null)
			{
				if (this.lineup_ == null)
				{
					this.Lineup = new LineupInfo();
				}
				this.Lineup.MergeFrom(other.Lineup);
			}
			if (other.rogueGameInfo_ != null)
			{
				if (this.rogueGameInfo_ == null)
				{
					this.RogueGameInfo = new RogueInfo();
				}
				this.RogueGameInfo.MergeFrom(other.RogueGameInfo);
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060031D5 RID: 12757 RVA: 0x000891C0 File Offset: 0x000873C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060031D6 RID: 12758 RVA: 0x000891CC File Offset: 0x000873CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 58U)
				{
					if (num == 26U)
					{
						if (this.scene_ == null)
						{
							this.Scene = new SceneInfo();
						}
						input.ReadMessage(this.Scene);
						continue;
					}
					if (num == 58U)
					{
						if (this.rogueGameInfo_ == null)
						{
							this.RogueGameInfo = new RogueInfo();
						}
						input.ReadMessage(this.RogueGameInfo);
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 98U)
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
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040013CC RID: 5068
		private static readonly MessageParser<EnterRogueScRsp> _parser = new MessageParser<EnterRogueScRsp>(() => new EnterRogueScRsp());

		// Token: 0x040013CD RID: 5069
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013CE RID: 5070
		public const int RotateInfoFieldNumber = 14;

		// Token: 0x040013CF RID: 5071
		private RogueMapRotateInfo rotateInfo_;

		// Token: 0x040013D0 RID: 5072
		public const int LineupFieldNumber = 12;

		// Token: 0x040013D1 RID: 5073
		private LineupInfo lineup_;

		// Token: 0x040013D2 RID: 5074
		public const int RogueGameInfoFieldNumber = 7;

		// Token: 0x040013D3 RID: 5075
		private RogueInfo rogueGameInfo_;

		// Token: 0x040013D4 RID: 5076
		public const int RetcodeFieldNumber = 11;

		// Token: 0x040013D5 RID: 5077
		private uint retcode_;

		// Token: 0x040013D6 RID: 5078
		public const int SceneFieldNumber = 3;

		// Token: 0x040013D7 RID: 5079
		private SceneInfo scene_;
	}
}
