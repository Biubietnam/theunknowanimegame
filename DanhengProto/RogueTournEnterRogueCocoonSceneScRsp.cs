using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FA9 RID: 4009
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournEnterRogueCocoonSceneScRsp : IMessage<RogueTournEnterRogueCocoonSceneScRsp>, IMessage, IEquatable<RogueTournEnterRogueCocoonSceneScRsp>, IDeepCloneable<RogueTournEnterRogueCocoonSceneScRsp>, IBufferMessage
	{
		// Token: 0x17003261 RID: 12897
		// (get) Token: 0x0600B2A2 RID: 45730 RVA: 0x001DFF9F File Offset: 0x001DE19F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournEnterRogueCocoonSceneScRsp> Parser
		{
			get
			{
				return RogueTournEnterRogueCocoonSceneScRsp._parser;
			}
		}

		// Token: 0x17003262 RID: 12898
		// (get) Token: 0x0600B2A3 RID: 45731 RVA: 0x001DFFA6 File Offset: 0x001DE1A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournEnterRogueCocoonSceneScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003263 RID: 12899
		// (get) Token: 0x0600B2A4 RID: 45732 RVA: 0x001DFFB8 File Offset: 0x001DE1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournEnterRogueCocoonSceneScRsp.Descriptor;
			}
		}

		// Token: 0x0600B2A5 RID: 45733 RVA: 0x001DFFBF File Offset: 0x001DE1BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnterRogueCocoonSceneScRsp()
		{
		}

		// Token: 0x0600B2A6 RID: 45734 RVA: 0x001DFFC8 File Offset: 0x001DE1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnterRogueCocoonSceneScRsp(RogueTournEnterRogueCocoonSceneScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.rogueTournCurSceneInfo_ = ((other.rogueTournCurSceneInfo_ != null) ? other.rogueTournCurSceneInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B2A7 RID: 45735 RVA: 0x001E0014 File Offset: 0x001DE214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnterRogueCocoonSceneScRsp Clone()
		{
			return new RogueTournEnterRogueCocoonSceneScRsp(this);
		}

		// Token: 0x17003264 RID: 12900
		// (get) Token: 0x0600B2A8 RID: 45736 RVA: 0x001E001C File Offset: 0x001DE21C
		// (set) Token: 0x0600B2A9 RID: 45737 RVA: 0x001E0024 File Offset: 0x001DE224
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

		// Token: 0x17003265 RID: 12901
		// (get) Token: 0x0600B2AA RID: 45738 RVA: 0x001E002D File Offset: 0x001DE22D
		// (set) Token: 0x0600B2AB RID: 45739 RVA: 0x001E0035 File Offset: 0x001DE235
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

		// Token: 0x0600B2AC RID: 45740 RVA: 0x001E003E File Offset: 0x001DE23E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournEnterRogueCocoonSceneScRsp);
		}

		// Token: 0x0600B2AD RID: 45741 RVA: 0x001E004C File Offset: 0x001DE24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournEnterRogueCocoonSceneScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.RogueTournCurSceneInfo, other.RogueTournCurSceneInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B2AE RID: 45742 RVA: 0x001E009C File Offset: 0x001DE29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.rogueTournCurSceneInfo_ != null)
			{
				num ^= this.RogueTournCurSceneInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B2AF RID: 45743 RVA: 0x001E00F1 File Offset: 0x001DE2F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B2B0 RID: 45744 RVA: 0x001E00F9 File Offset: 0x001DE2F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B2B1 RID: 45745 RVA: 0x001E0104 File Offset: 0x001DE304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this.rogueTournCurSceneInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.RogueTournCurSceneInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B2B2 RID: 45746 RVA: 0x001E0160 File Offset: 0x001DE360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.rogueTournCurSceneInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournCurSceneInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B2B3 RID: 45747 RVA: 0x001E01B8 File Offset: 0x001DE3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournEnterRogueCocoonSceneScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.rogueTournCurSceneInfo_ != null)
			{
				if (this.rogueTournCurSceneInfo_ == null)
				{
					this.RogueTournCurSceneInfo = new RogueTournCurSceneInfo();
				}
				this.RogueTournCurSceneInfo.MergeFrom(other.RogueTournCurSceneInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B2B4 RID: 45748 RVA: 0x001E0220 File Offset: 0x001DE420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B2B5 RID: 45749 RVA: 0x001E022C File Offset: 0x001DE42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004897 RID: 18583
		private static readonly MessageParser<RogueTournEnterRogueCocoonSceneScRsp> _parser = new MessageParser<RogueTournEnterRogueCocoonSceneScRsp>(() => new RogueTournEnterRogueCocoonSceneScRsp());

		// Token: 0x04004898 RID: 18584
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004899 RID: 18585
		public const int RetcodeFieldNumber = 9;

		// Token: 0x0400489A RID: 18586
		private uint retcode_;

		// Token: 0x0400489B RID: 18587
		public const int RogueTournCurSceneInfoFieldNumber = 15;

		// Token: 0x0400489C RID: 18588
		private RogueTournCurSceneInfo rogueTournCurSceneInfo_;
	}
}
