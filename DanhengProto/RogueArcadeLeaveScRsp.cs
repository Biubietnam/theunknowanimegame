using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DFD RID: 3581
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueArcadeLeaveScRsp : IMessage<RogueArcadeLeaveScRsp>, IMessage, IEquatable<RogueArcadeLeaveScRsp>, IDeepCloneable<RogueArcadeLeaveScRsp>, IBufferMessage
	{
		// Token: 0x17002D38 RID: 11576
		// (get) Token: 0x0600A020 RID: 40992 RVA: 0x001ADC35 File Offset: 0x001ABE35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueArcadeLeaveScRsp> Parser
		{
			get
			{
				return RogueArcadeLeaveScRsp._parser;
			}
		}

		// Token: 0x17002D39 RID: 11577
		// (get) Token: 0x0600A021 RID: 40993 RVA: 0x001ADC3C File Offset: 0x001ABE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueArcadeLeaveScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D3A RID: 11578
		// (get) Token: 0x0600A022 RID: 40994 RVA: 0x001ADC4E File Offset: 0x001ABE4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueArcadeLeaveScRsp.Descriptor;
			}
		}

		// Token: 0x0600A023 RID: 40995 RVA: 0x001ADC55 File Offset: 0x001ABE55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArcadeLeaveScRsp()
		{
		}

		// Token: 0x0600A024 RID: 40996 RVA: 0x001ADC60 File Offset: 0x001ABE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArcadeLeaveScRsp(RogueArcadeLeaveScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.rogueTournCurSceneInfo_ = ((other.rogueTournCurSceneInfo_ != null) ? other.rogueTournCurSceneInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A025 RID: 40997 RVA: 0x001ADCAC File Offset: 0x001ABEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArcadeLeaveScRsp Clone()
		{
			return new RogueArcadeLeaveScRsp(this);
		}

		// Token: 0x17002D3B RID: 11579
		// (get) Token: 0x0600A026 RID: 40998 RVA: 0x001ADCB4 File Offset: 0x001ABEB4
		// (set) Token: 0x0600A027 RID: 40999 RVA: 0x001ADCBC File Offset: 0x001ABEBC
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

		// Token: 0x17002D3C RID: 11580
		// (get) Token: 0x0600A028 RID: 41000 RVA: 0x001ADCC5 File Offset: 0x001ABEC5
		// (set) Token: 0x0600A029 RID: 41001 RVA: 0x001ADCCD File Offset: 0x001ABECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IKENAAJDAFF RogueTournCurSceneInfo
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

		// Token: 0x0600A02A RID: 41002 RVA: 0x001ADCD6 File Offset: 0x001ABED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueArcadeLeaveScRsp);
		}

		// Token: 0x0600A02B RID: 41003 RVA: 0x001ADCE4 File Offset: 0x001ABEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueArcadeLeaveScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.RogueTournCurSceneInfo, other.RogueTournCurSceneInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A02C RID: 41004 RVA: 0x001ADD34 File Offset: 0x001ABF34
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

		// Token: 0x0600A02D RID: 41005 RVA: 0x001ADD89 File Offset: 0x001ABF89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A02E RID: 41006 RVA: 0x001ADD91 File Offset: 0x001ABF91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A02F RID: 41007 RVA: 0x001ADD9C File Offset: 0x001ABF9C
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
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A030 RID: 41008 RVA: 0x001ADDF8 File Offset: 0x001ABFF8
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

		// Token: 0x0600A031 RID: 41009 RVA: 0x001ADE50 File Offset: 0x001AC050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueArcadeLeaveScRsp other)
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
					this.RogueTournCurSceneInfo = new IKENAAJDAFF();
				}
				this.RogueTournCurSceneInfo.MergeFrom(other.RogueTournCurSceneInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A032 RID: 41010 RVA: 0x001ADEB8 File Offset: 0x001AC0B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A033 RID: 41011 RVA: 0x001ADEC4 File Offset: 0x001AC0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 96U)
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
						this.RogueTournCurSceneInfo = new IKENAAJDAFF();
					}
					input.ReadMessage(this.RogueTournCurSceneInfo);
				}
			}
		}

		// Token: 0x040041A1 RID: 16801
		private static readonly MessageParser<RogueArcadeLeaveScRsp> _parser = new MessageParser<RogueArcadeLeaveScRsp>(() => new RogueArcadeLeaveScRsp());

		// Token: 0x040041A2 RID: 16802
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041A3 RID: 16803
		public const int RetcodeFieldNumber = 12;

		// Token: 0x040041A4 RID: 16804
		private uint retcode_;

		// Token: 0x040041A5 RID: 16805
		public const int RogueTournCurSceneInfoFieldNumber = 2;

		// Token: 0x040041A6 RID: 16806
		private IKENAAJDAFF rogueTournCurSceneInfo_;
	}
}
