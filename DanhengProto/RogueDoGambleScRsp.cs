using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E75 RID: 3701
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueDoGambleScRsp : IMessage<RogueDoGambleScRsp>, IMessage, IEquatable<RogueDoGambleScRsp>, IDeepCloneable<RogueDoGambleScRsp>, IBufferMessage
	{
		// Token: 0x17002E97 RID: 11927
		// (get) Token: 0x0600A518 RID: 42264 RVA: 0x001BBB43 File Offset: 0x001B9D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueDoGambleScRsp> Parser
		{
			get
			{
				return RogueDoGambleScRsp._parser;
			}
		}

		// Token: 0x17002E98 RID: 11928
		// (get) Token: 0x0600A519 RID: 42265 RVA: 0x001BBB4A File Offset: 0x001B9D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueDoGambleScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E99 RID: 11929
		// (get) Token: 0x0600A51A RID: 42266 RVA: 0x001BBB5C File Offset: 0x001B9D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueDoGambleScRsp.Descriptor;
			}
		}

		// Token: 0x0600A51B RID: 42267 RVA: 0x001BBB63 File Offset: 0x001B9D63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueDoGambleScRsp()
		{
		}

		// Token: 0x0600A51C RID: 42268 RVA: 0x001BBB6C File Offset: 0x001B9D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueDoGambleScRsp(RogueDoGambleScRsp other) : this()
		{
			this.iIDKIGDNCKG_ = other.iIDKIGDNCKG_;
			this.retcode_ = other.retcode_;
			this.dEIAFKNFMGO_ = other.dEIAFKNFMGO_;
			this.gambleInfo_ = ((other.gambleInfo_ != null) ? other.gambleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A51D RID: 42269 RVA: 0x001BBBD0 File Offset: 0x001B9DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueDoGambleScRsp Clone()
		{
			return new RogueDoGambleScRsp(this);
		}

		// Token: 0x17002E9A RID: 11930
		// (get) Token: 0x0600A51E RID: 42270 RVA: 0x001BBBD8 File Offset: 0x001B9DD8
		// (set) Token: 0x0600A51F RID: 42271 RVA: 0x001BBBE0 File Offset: 0x001B9DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IIDKIGDNCKG
		{
			get
			{
				return this.iIDKIGDNCKG_;
			}
			set
			{
				this.iIDKIGDNCKG_ = value;
			}
		}

		// Token: 0x17002E9B RID: 11931
		// (get) Token: 0x0600A520 RID: 42272 RVA: 0x001BBBE9 File Offset: 0x001B9DE9
		// (set) Token: 0x0600A521 RID: 42273 RVA: 0x001BBBF1 File Offset: 0x001B9DF1
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

		// Token: 0x17002E9C RID: 11932
		// (get) Token: 0x0600A522 RID: 42274 RVA: 0x001BBBFA File Offset: 0x001B9DFA
		// (set) Token: 0x0600A523 RID: 42275 RVA: 0x001BBC02 File Offset: 0x001B9E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DEIAFKNFMGO
		{
			get
			{
				return this.dEIAFKNFMGO_;
			}
			set
			{
				this.dEIAFKNFMGO_ = value;
			}
		}

		// Token: 0x17002E9D RID: 11933
		// (get) Token: 0x0600A524 RID: 42276 RVA: 0x001BBC0B File Offset: 0x001B9E0B
		// (set) Token: 0x0600A525 RID: 42277 RVA: 0x001BBC13 File Offset: 0x001B9E13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGambleInfo GambleInfo
		{
			get
			{
				return this.gambleInfo_;
			}
			set
			{
				this.gambleInfo_ = value;
			}
		}

		// Token: 0x0600A526 RID: 42278 RVA: 0x001BBC1C File Offset: 0x001B9E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueDoGambleScRsp);
		}

		// Token: 0x0600A527 RID: 42279 RVA: 0x001BBC2C File Offset: 0x001B9E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueDoGambleScRsp other)
		{
			return other != null && (other == this || (this.IIDKIGDNCKG == other.IIDKIGDNCKG && this.Retcode == other.Retcode && this.DEIAFKNFMGO == other.DEIAFKNFMGO && object.Equals(this.GambleInfo, other.GambleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A528 RID: 42280 RVA: 0x001BBC9C File Offset: 0x001B9E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IIDKIGDNCKG != 0U)
			{
				num ^= this.IIDKIGDNCKG.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.DEIAFKNFMGO != 0U)
			{
				num ^= this.DEIAFKNFMGO.GetHashCode();
			}
			if (this.gambleInfo_ != null)
			{
				num ^= this.GambleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A529 RID: 42281 RVA: 0x001BBD23 File Offset: 0x001B9F23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A52A RID: 42282 RVA: 0x001BBD2B File Offset: 0x001B9F2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A52B RID: 42283 RVA: 0x001BBD34 File Offset: 0x001B9F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.DEIAFKNFMGO != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.DEIAFKNFMGO);
			}
			if (this.gambleInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.GambleInfo);
			}
			if (this.IIDKIGDNCKG != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.IIDKIGDNCKG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A52C RID: 42284 RVA: 0x001BBDC8 File Offset: 0x001B9FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IIDKIGDNCKG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IIDKIGDNCKG);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.DEIAFKNFMGO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DEIAFKNFMGO);
			}
			if (this.gambleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GambleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A52D RID: 42285 RVA: 0x001BBE50 File Offset: 0x001BA050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueDoGambleScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IIDKIGDNCKG != 0U)
			{
				this.IIDKIGDNCKG = other.IIDKIGDNCKG;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.DEIAFKNFMGO != 0U)
			{
				this.DEIAFKNFMGO = other.DEIAFKNFMGO;
			}
			if (other.gambleInfo_ != null)
			{
				if (this.gambleInfo_ == null)
				{
					this.GambleInfo = new RogueGambleInfo();
				}
				this.GambleInfo.MergeFrom(other.GambleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A52E RID: 42286 RVA: 0x001BBEE0 File Offset: 0x001BA0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A52F RID: 42287 RVA: 0x001BBEEC File Offset: 0x001BA0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 80U)
				{
					if (num == 16U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.DEIAFKNFMGO = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						if (this.gambleInfo_ == null)
						{
							this.GambleInfo = new RogueGambleInfo();
						}
						input.ReadMessage(this.GambleInfo);
						continue;
					}
					if (num == 120U)
					{
						this.IIDKIGDNCKG = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400436E RID: 17262
		private static readonly MessageParser<RogueDoGambleScRsp> _parser = new MessageParser<RogueDoGambleScRsp>(() => new RogueDoGambleScRsp());

		// Token: 0x0400436F RID: 17263
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004370 RID: 17264
		public const int IIDKIGDNCKGFieldNumber = 15;

		// Token: 0x04004371 RID: 17265
		private uint iIDKIGDNCKG_;

		// Token: 0x04004372 RID: 17266
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04004373 RID: 17267
		private uint retcode_;

		// Token: 0x04004374 RID: 17268
		public const int DEIAFKNFMGOFieldNumber = 10;

		// Token: 0x04004375 RID: 17269
		private uint dEIAFKNFMGO_;

		// Token: 0x04004376 RID: 17270
		public const int GambleInfoFieldNumber = 13;

		// Token: 0x04004377 RID: 17271
		private RogueGambleInfo gambleInfo_;
	}
}
