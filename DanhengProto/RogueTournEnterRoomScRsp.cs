using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FAD RID: 4013
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournEnterRoomScRsp : IMessage<RogueTournEnterRoomScRsp>, IMessage, IEquatable<RogueTournEnterRoomScRsp>, IDeepCloneable<RogueTournEnterRoomScRsp>, IBufferMessage
	{
		// Token: 0x1700326D RID: 12909
		// (get) Token: 0x0600B2D0 RID: 45776 RVA: 0x001E0687 File Offset: 0x001DE887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournEnterRoomScRsp> Parser
		{
			get
			{
				return RogueTournEnterRoomScRsp._parser;
			}
		}

		// Token: 0x1700326E RID: 12910
		// (get) Token: 0x0600B2D1 RID: 45777 RVA: 0x001E068E File Offset: 0x001DE88E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournEnterRoomScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700326F RID: 12911
		// (get) Token: 0x0600B2D2 RID: 45778 RVA: 0x001E06A0 File Offset: 0x001DE8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournEnterRoomScRsp.Descriptor;
			}
		}

		// Token: 0x0600B2D3 RID: 45779 RVA: 0x001E06A7 File Offset: 0x001DE8A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnterRoomScRsp()
		{
		}

		// Token: 0x0600B2D4 RID: 45780 RVA: 0x001E06B0 File Offset: 0x001DE8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnterRoomScRsp(RogueTournEnterRoomScRsp other) : this()
		{
			this.rogueTournCurSceneInfo_ = ((other.rogueTournCurSceneInfo_ != null) ? other.rogueTournCurSceneInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B2D5 RID: 45781 RVA: 0x001E06FC File Offset: 0x001DE8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnterRoomScRsp Clone()
		{
			return new RogueTournEnterRoomScRsp(this);
		}

		// Token: 0x17003270 RID: 12912
		// (get) Token: 0x0600B2D6 RID: 45782 RVA: 0x001E0704 File Offset: 0x001DE904
		// (set) Token: 0x0600B2D7 RID: 45783 RVA: 0x001E070C File Offset: 0x001DE90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournCurSceneInfo RogueTournCurSceneInfo
		{
			get
			{
				return this.rogueTournCurSceneInfo_;
			}
			set
			{
				this.rogueTournCurSceneInfo_ = value;
			}
		}

		// Token: 0x17003271 RID: 12913
		// (get) Token: 0x0600B2D8 RID: 45784 RVA: 0x001E0715 File Offset: 0x001DE915
		// (set) Token: 0x0600B2D9 RID: 45785 RVA: 0x001E071D File Offset: 0x001DE91D
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

		// Token: 0x0600B2DA RID: 45786 RVA: 0x001E0726 File Offset: 0x001DE926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournEnterRoomScRsp);
		}

		// Token: 0x0600B2DB RID: 45787 RVA: 0x001E0734 File Offset: 0x001DE934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournEnterRoomScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.RogueTournCurSceneInfo, other.RogueTournCurSceneInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B2DC RID: 45788 RVA: 0x001E0784 File Offset: 0x001DE984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueTournCurSceneInfo_ != null)
			{
				num ^= this.RogueTournCurSceneInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B2DD RID: 45789 RVA: 0x001E07D9 File Offset: 0x001DE9D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B2DE RID: 45790 RVA: 0x001E07E1 File Offset: 0x001DE9E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B2DF RID: 45791 RVA: 0x001E07EC File Offset: 0x001DE9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueTournCurSceneInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RogueTournCurSceneInfo);
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

		// Token: 0x0600B2E0 RID: 45792 RVA: 0x001E0848 File Offset: 0x001DEA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueTournCurSceneInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournCurSceneInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B2E1 RID: 45793 RVA: 0x001E08A0 File Offset: 0x001DEAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournEnterRoomScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueTournCurSceneInfo_ != null)
			{
				if (this.rogueTournCurSceneInfo_ == null)
				{
					this.RogueTournCurSceneInfo = new RogueTournCurSceneInfo();
				}
				this.RogueTournCurSceneInfo.MergeFrom(other.RogueTournCurSceneInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B2E2 RID: 45794 RVA: 0x001E0908 File Offset: 0x001DEB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B2E3 RID: 45795 RVA: 0x001E0914 File Offset: 0x001DEB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.rogueTournCurSceneInfo_ == null)
					{
						this.RogueTournCurSceneInfo = new RogueTournCurSceneInfo();
					}
					input.ReadMessage(this.RogueTournCurSceneInfo);
				}
			}
		}

		// Token: 0x040048A5 RID: 18597
		private static readonly MessageParser<RogueTournEnterRoomScRsp> _parser = new MessageParser<RogueTournEnterRoomScRsp>(() => new RogueTournEnterRoomScRsp());

		// Token: 0x040048A6 RID: 18598
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048A7 RID: 18599
		public const int RogueTournCurSceneInfoFieldNumber = 2;

		// Token: 0x040048A8 RID: 18600
		private RogueTournCurSceneInfo rogueTournCurSceneInfo_;

		// Token: 0x040048A9 RID: 18601
		public const int RetcodeFieldNumber = 5;

		// Token: 0x040048AA RID: 18602
		private uint retcode_;
	}
}
