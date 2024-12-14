using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FAF RID: 4015
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournEnterScRsp : IMessage<RogueTournEnterScRsp>, IMessage, IEquatable<RogueTournEnterScRsp>, IDeepCloneable<RogueTournEnterScRsp>, IBufferMessage
	{
		// Token: 0x17003273 RID: 12915
		// (get) Token: 0x0600B2E7 RID: 45799 RVA: 0x001E0A57 File Offset: 0x001DEC57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournEnterScRsp> Parser
		{
			get
			{
				return RogueTournEnterScRsp._parser;
			}
		}

		// Token: 0x17003274 RID: 12916
		// (get) Token: 0x0600B2E8 RID: 45800 RVA: 0x001E0A5E File Offset: 0x001DEC5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournEnterScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003275 RID: 12917
		// (get) Token: 0x0600B2E9 RID: 45801 RVA: 0x001E0A70 File Offset: 0x001DEC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournEnterScRsp.Descriptor;
			}
		}

		// Token: 0x0600B2EA RID: 45802 RVA: 0x001E0A77 File Offset: 0x001DEC77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnterScRsp()
		{
		}

		// Token: 0x0600B2EB RID: 45803 RVA: 0x001E0A80 File Offset: 0x001DEC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnterScRsp(RogueTournEnterScRsp other) : this()
		{
			this.rogueTournCurSceneInfo_ = ((other.rogueTournCurSceneInfo_ != null) ? other.rogueTournCurSceneInfo_.Clone() : null);
			this.rogueTournCurInfo_ = ((other.rogueTournCurInfo_ != null) ? other.rogueTournCurInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B2EC RID: 45804 RVA: 0x001E0AE8 File Offset: 0x001DECE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnterScRsp Clone()
		{
			return new RogueTournEnterScRsp(this);
		}

		// Token: 0x17003276 RID: 12918
		// (get) Token: 0x0600B2ED RID: 45805 RVA: 0x001E0AF0 File Offset: 0x001DECF0
		// (set) Token: 0x0600B2EE RID: 45806 RVA: 0x001E0AF8 File Offset: 0x001DECF8
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

		// Token: 0x17003277 RID: 12919
		// (get) Token: 0x0600B2EF RID: 45807 RVA: 0x001E0B01 File Offset: 0x001DED01
		// (set) Token: 0x0600B2F0 RID: 45808 RVA: 0x001E0B09 File Offset: 0x001DED09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournCurInfo RogueTournCurInfo
		{
			get
			{
				return this.rogueTournCurInfo_;
			}
			set
			{
				this.rogueTournCurInfo_ = value;
			}
		}

		// Token: 0x17003278 RID: 12920
		// (get) Token: 0x0600B2F1 RID: 45809 RVA: 0x001E0B12 File Offset: 0x001DED12
		// (set) Token: 0x0600B2F2 RID: 45810 RVA: 0x001E0B1A File Offset: 0x001DED1A
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

		// Token: 0x0600B2F3 RID: 45811 RVA: 0x001E0B23 File Offset: 0x001DED23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournEnterScRsp);
		}

		// Token: 0x0600B2F4 RID: 45812 RVA: 0x001E0B34 File Offset: 0x001DED34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournEnterScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.RogueTournCurSceneInfo, other.RogueTournCurSceneInfo) && object.Equals(this.RogueTournCurInfo, other.RogueTournCurInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B2F5 RID: 45813 RVA: 0x001E0B98 File Offset: 0x001DED98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueTournCurSceneInfo_ != null)
			{
				num ^= this.RogueTournCurSceneInfo.GetHashCode();
			}
			if (this.rogueTournCurInfo_ != null)
			{
				num ^= this.RogueTournCurInfo.GetHashCode();
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

		// Token: 0x0600B2F6 RID: 45814 RVA: 0x001E0C03 File Offset: 0x001DEE03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B2F7 RID: 45815 RVA: 0x001E0C0B File Offset: 0x001DEE0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B2F8 RID: 45816 RVA: 0x001E0C14 File Offset: 0x001DEE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueTournCurSceneInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.RogueTournCurSceneInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			if (this.rogueTournCurInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.RogueTournCurInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B2F9 RID: 45817 RVA: 0x001E0C8C File Offset: 0x001DEE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueTournCurSceneInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournCurSceneInfo);
			}
			if (this.rogueTournCurInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournCurInfo);
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

		// Token: 0x0600B2FA RID: 45818 RVA: 0x001E0CFC File Offset: 0x001DEEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournEnterScRsp other)
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
			if (other.rogueTournCurInfo_ != null)
			{
				if (this.rogueTournCurInfo_ == null)
				{
					this.RogueTournCurInfo = new RogueTournCurInfo();
				}
				this.RogueTournCurInfo.MergeFrom(other.RogueTournCurInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B2FB RID: 45819 RVA: 0x001E0D90 File Offset: 0x001DEF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B2FC RID: 45820 RVA: 0x001E0D9C File Offset: 0x001DEF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 56U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.rogueTournCurInfo_ == null)
							{
								this.RogueTournCurInfo = new RogueTournCurInfo();
							}
							input.ReadMessage(this.RogueTournCurInfo);
						}
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

		// Token: 0x040048AC RID: 18604
		private static readonly MessageParser<RogueTournEnterScRsp> _parser = new MessageParser<RogueTournEnterScRsp>(() => new RogueTournEnterScRsp());

		// Token: 0x040048AD RID: 18605
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048AE RID: 18606
		public const int RogueTournCurSceneInfoFieldNumber = 3;

		// Token: 0x040048AF RID: 18607
		private RogueTournCurSceneInfo rogueTournCurSceneInfo_;

		// Token: 0x040048B0 RID: 18608
		public const int RogueTournCurInfoFieldNumber = 15;

		// Token: 0x040048B1 RID: 18609
		private RogueTournCurInfo rogueTournCurInfo_;

		// Token: 0x040048B2 RID: 18610
		public const int RetcodeFieldNumber = 7;

		// Token: 0x040048B3 RID: 18611
		private uint retcode_;
	}
}
