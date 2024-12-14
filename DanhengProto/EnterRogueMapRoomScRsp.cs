using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200045B RID: 1115
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterRogueMapRoomScRsp : IMessage<EnterRogueMapRoomScRsp>, IMessage, IEquatable<EnterRogueMapRoomScRsp>, IDeepCloneable<EnterRogueMapRoomScRsp>, IBufferMessage
	{
		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x060031A0 RID: 12704 RVA: 0x000886BB File Offset: 0x000868BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterRogueMapRoomScRsp> Parser
		{
			get
			{
				return EnterRogueMapRoomScRsp._parser;
			}
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x060031A1 RID: 12705 RVA: 0x000886C2 File Offset: 0x000868C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterRogueMapRoomScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x060031A2 RID: 12706 RVA: 0x000886D4 File Offset: 0x000868D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterRogueMapRoomScRsp.Descriptor;
			}
		}

		// Token: 0x060031A3 RID: 12707 RVA: 0x000886DB File Offset: 0x000868DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterRogueMapRoomScRsp()
		{
		}

		// Token: 0x060031A4 RID: 12708 RVA: 0x000886E4 File Offset: 0x000868E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterRogueMapRoomScRsp(EnterRogueMapRoomScRsp other) : this()
		{
			this.scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
			this.rotateInfo_ = ((other.rotateInfo_ != null) ? other.rotateInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
			this.curSiteId_ = other.curSiteId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060031A5 RID: 12709 RVA: 0x00088774 File Offset: 0x00086974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterRogueMapRoomScRsp Clone()
		{
			return new EnterRogueMapRoomScRsp(this);
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x060031A6 RID: 12710 RVA: 0x0008877C File Offset: 0x0008697C
		// (set) Token: 0x060031A7 RID: 12711 RVA: 0x00088784 File Offset: 0x00086984
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

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x060031A8 RID: 12712 RVA: 0x0008878D File Offset: 0x0008698D
		// (set) Token: 0x060031A9 RID: 12713 RVA: 0x00088795 File Offset: 0x00086995
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

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x060031AA RID: 12714 RVA: 0x0008879E File Offset: 0x0008699E
		// (set) Token: 0x060031AB RID: 12715 RVA: 0x000887A6 File Offset: 0x000869A6
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

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x060031AC RID: 12716 RVA: 0x000887AF File Offset: 0x000869AF
		// (set) Token: 0x060031AD RID: 12717 RVA: 0x000887B7 File Offset: 0x000869B7
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

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x060031AE RID: 12718 RVA: 0x000887C0 File Offset: 0x000869C0
		// (set) Token: 0x060031AF RID: 12719 RVA: 0x000887C8 File Offset: 0x000869C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurSiteId
		{
			get
			{
				return this.curSiteId_;
			}
			set
			{
				this.curSiteId_ = value;
			}
		}

		// Token: 0x060031B0 RID: 12720 RVA: 0x000887D1 File Offset: 0x000869D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterRogueMapRoomScRsp);
		}

		// Token: 0x060031B1 RID: 12721 RVA: 0x000887E0 File Offset: 0x000869E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterRogueMapRoomScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Scene, other.Scene) && object.Equals(this.RotateInfo, other.RotateInfo) && this.Retcode == other.Retcode && object.Equals(this.Lineup, other.Lineup) && this.CurSiteId == other.CurSiteId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060031B2 RID: 12722 RVA: 0x00088868 File Offset: 0x00086A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.scene_ != null)
			{
				num ^= this.Scene.GetHashCode();
			}
			if (this.rotateInfo_ != null)
			{
				num ^= this.RotateInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.lineup_ != null)
			{
				num ^= this.Lineup.GetHashCode();
			}
			if (this.CurSiteId != 0U)
			{
				num ^= this.CurSiteId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x00088902 File Offset: 0x00086B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060031B4 RID: 12724 RVA: 0x0008890A File Offset: 0x00086B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060031B5 RID: 12725 RVA: 0x00088914 File Offset: 0x00086B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rotateInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RotateInfo);
			}
			if (this.scene_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Scene);
			}
			if (this.lineup_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Lineup);
			}
			if (this.CurSiteId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.CurSiteId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060031B6 RID: 12726 RVA: 0x000889C4 File Offset: 0x00086BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.scene_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Scene);
			}
			if (this.rotateInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RotateInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.lineup_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Lineup);
			}
			if (this.CurSiteId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurSiteId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060031B7 RID: 12727 RVA: 0x00088A64 File Offset: 0x00086C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterRogueMapRoomScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.scene_ != null)
			{
				if (this.scene_ == null)
				{
					this.Scene = new SceneInfo();
				}
				this.Scene.MergeFrom(other.Scene);
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
			if (other.lineup_ != null)
			{
				if (this.lineup_ == null)
				{
					this.Lineup = new LineupInfo();
				}
				this.Lineup.MergeFrom(other.Lineup);
			}
			if (other.CurSiteId != 0U)
			{
				this.CurSiteId = other.CurSiteId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060031B8 RID: 12728 RVA: 0x00088B38 File Offset: 0x00086D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060031B9 RID: 12729 RVA: 0x00088B44 File Offset: 0x00086D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 18U)
				{
					if (num == 10U)
					{
						if (this.rotateInfo_ == null)
						{
							this.RotateInfo = new RogueMapRotateInfo();
						}
						input.ReadMessage(this.RotateInfo);
						continue;
					}
					if (num == 18U)
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
					if (num == 26U)
					{
						if (this.lineup_ == null)
						{
							this.Lineup = new LineupInfo();
						}
						input.ReadMessage(this.Lineup);
						continue;
					}
					if (num == 32U)
					{
						this.CurSiteId = input.ReadUInt32();
						continue;
					}
					if (num == 40U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040013BF RID: 5055
		private static readonly MessageParser<EnterRogueMapRoomScRsp> _parser = new MessageParser<EnterRogueMapRoomScRsp>(() => new EnterRogueMapRoomScRsp());

		// Token: 0x040013C0 RID: 5056
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013C1 RID: 5057
		public const int SceneFieldNumber = 2;

		// Token: 0x040013C2 RID: 5058
		private SceneInfo scene_;

		// Token: 0x040013C3 RID: 5059
		public const int RotateInfoFieldNumber = 1;

		// Token: 0x040013C4 RID: 5060
		private RogueMapRotateInfo rotateInfo_;

		// Token: 0x040013C5 RID: 5061
		public const int RetcodeFieldNumber = 5;

		// Token: 0x040013C6 RID: 5062
		private uint retcode_;

		// Token: 0x040013C7 RID: 5063
		public const int LineupFieldNumber = 3;

		// Token: 0x040013C8 RID: 5064
		private LineupInfo lineup_;

		// Token: 0x040013C9 RID: 5065
		public const int CurSiteIdFieldNumber = 4;

		// Token: 0x040013CA RID: 5066
		private uint curSiteId_;
	}
}
