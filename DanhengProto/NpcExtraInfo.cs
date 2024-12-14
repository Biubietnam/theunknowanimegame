using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C2F RID: 3119
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NpcExtraInfo : IMessage<NpcExtraInfo>, IMessage, IEquatable<NpcExtraInfo>, IDeepCloneable<NpcExtraInfo>, IBufferMessage
	{
		// Token: 0x170026C8 RID: 9928
		// (get) Token: 0x06008A34 RID: 35380 RVA: 0x0016CEE7 File Offset: 0x0016B0E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NpcExtraInfo> Parser
		{
			get
			{
				return NpcExtraInfo._parser;
			}
		}

		// Token: 0x170026C9 RID: 9929
		// (get) Token: 0x06008A35 RID: 35381 RVA: 0x0016CEEE File Offset: 0x0016B0EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NpcExtraInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170026CA RID: 9930
		// (get) Token: 0x06008A36 RID: 35382 RVA: 0x0016CF00 File Offset: 0x0016B100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcExtraInfo.Descriptor;
			}
		}

		// Token: 0x06008A37 RID: 35383 RVA: 0x0016CF07 File Offset: 0x0016B107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcExtraInfo()
		{
		}

		// Token: 0x06008A38 RID: 35384 RVA: 0x0016CF10 File Offset: 0x0016B110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcExtraInfo(NpcExtraInfo other) : this()
		{
			this.rogueGameInfo_ = ((other.rogueGameInfo_ != null) ? other.rogueGameInfo_.Clone() : null);
			this.pGJKGLDABML_ = ((other.pGJKGLDABML_ != null) ? other.pGJKGLDABML_.Clone() : null);
			this.nNLIGGHEBFP_ = ((other.nNLIGGHEBFP_ != null) ? other.nNLIGGHEBFP_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008A39 RID: 35385 RVA: 0x0016CF88 File Offset: 0x0016B188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcExtraInfo Clone()
		{
			return new NpcExtraInfo(this);
		}

		// Token: 0x170026CB RID: 9931
		// (get) Token: 0x06008A3A RID: 35386 RVA: 0x0016CF90 File Offset: 0x0016B190
		// (set) Token: 0x06008A3B RID: 35387 RVA: 0x0016CF98 File Offset: 0x0016B198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcRogueGameInfo RogueGameInfo
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

		// Token: 0x170026CC RID: 9932
		// (get) Token: 0x06008A3C RID: 35388 RVA: 0x0016CFA1 File Offset: 0x0016B1A1
		// (set) Token: 0x06008A3D RID: 35389 RVA: 0x0016CFA9 File Offset: 0x0016B1A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PGIMFOFDPGF PGJKGLDABML
		{
			get
			{
				return this.pGJKGLDABML_;
			}
			set
			{
				this.pGJKGLDABML_ = value;
			}
		}

		// Token: 0x170026CD RID: 9933
		// (get) Token: 0x06008A3E RID: 35390 RVA: 0x0016CFB2 File Offset: 0x0016B1B2
		// (set) Token: 0x06008A3F RID: 35391 RVA: 0x0016CFBA File Offset: 0x0016B1BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MFDHINNNEGL NNLIGGHEBFP
		{
			get
			{
				return this.nNLIGGHEBFP_;
			}
			set
			{
				this.nNLIGGHEBFP_ = value;
			}
		}

		// Token: 0x06008A40 RID: 35392 RVA: 0x0016CFC3 File Offset: 0x0016B1C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcExtraInfo);
		}

		// Token: 0x06008A41 RID: 35393 RVA: 0x0016CFD4 File Offset: 0x0016B1D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcExtraInfo other)
		{
			return other != null && (other == this || (object.Equals(this.RogueGameInfo, other.RogueGameInfo) && object.Equals(this.PGJKGLDABML, other.PGJKGLDABML) && object.Equals(this.NNLIGGHEBFP, other.NNLIGGHEBFP) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008A42 RID: 35394 RVA: 0x0016D03C File Offset: 0x0016B23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueGameInfo_ != null)
			{
				num ^= this.RogueGameInfo.GetHashCode();
			}
			if (this.pGJKGLDABML_ != null)
			{
				num ^= this.PGJKGLDABML.GetHashCode();
			}
			if (this.nNLIGGHEBFP_ != null)
			{
				num ^= this.NNLIGGHEBFP.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008A43 RID: 35395 RVA: 0x0016D0A4 File Offset: 0x0016B2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008A44 RID: 35396 RVA: 0x0016D0AC File Offset: 0x0016B2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008A45 RID: 35397 RVA: 0x0016D0B8 File Offset: 0x0016B2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pGJKGLDABML_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.PGJKGLDABML);
			}
			if (this.nNLIGGHEBFP_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.NNLIGGHEBFP);
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

		// Token: 0x06008A46 RID: 35398 RVA: 0x0016D130 File Offset: 0x0016B330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueGameInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueGameInfo);
			}
			if (this.pGJKGLDABML_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PGJKGLDABML);
			}
			if (this.nNLIGGHEBFP_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NNLIGGHEBFP);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008A47 RID: 35399 RVA: 0x0016D1A0 File Offset: 0x0016B3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcExtraInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueGameInfo_ != null)
			{
				if (this.rogueGameInfo_ == null)
				{
					this.RogueGameInfo = new NpcRogueGameInfo();
				}
				this.RogueGameInfo.MergeFrom(other.RogueGameInfo);
			}
			if (other.pGJKGLDABML_ != null)
			{
				if (this.pGJKGLDABML_ == null)
				{
					this.PGJKGLDABML = new PGIMFOFDPGF();
				}
				this.PGJKGLDABML.MergeFrom(other.PGJKGLDABML);
			}
			if (other.nNLIGGHEBFP_ != null)
			{
				if (this.nNLIGGHEBFP_ == null)
				{
					this.NNLIGGHEBFP = new MFDHINNNEGL();
				}
				this.NNLIGGHEBFP.MergeFrom(other.NNLIGGHEBFP);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008A48 RID: 35400 RVA: 0x0016D24C File Offset: 0x0016B44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008A49 RID: 35401 RVA: 0x0016D258 File Offset: 0x0016B458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 82U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.rogueGameInfo_ == null)
							{
								this.RogueGameInfo = new NpcRogueGameInfo();
							}
							input.ReadMessage(this.RogueGameInfo);
						}
					}
					else
					{
						if (this.nNLIGGHEBFP_ == null)
						{
							this.NNLIGGHEBFP = new MFDHINNNEGL();
						}
						input.ReadMessage(this.NNLIGGHEBFP);
					}
				}
				else
				{
					if (this.pGJKGLDABML_ == null)
					{
						this.PGJKGLDABML = new PGIMFOFDPGF();
					}
					input.ReadMessage(this.PGJKGLDABML);
				}
			}
		}

		// Token: 0x04003500 RID: 13568
		private static readonly MessageParser<NpcExtraInfo> _parser = new MessageParser<NpcExtraInfo>(() => new NpcExtraInfo());

		// Token: 0x04003501 RID: 13569
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003502 RID: 13570
		public const int RogueGameInfoFieldNumber = 15;

		// Token: 0x04003503 RID: 13571
		private NpcRogueGameInfo rogueGameInfo_;

		// Token: 0x04003504 RID: 13572
		public const int PGJKGLDABMLFieldNumber = 2;

		// Token: 0x04003505 RID: 13573
		private PGIMFOFDPGF pGJKGLDABML_;

		// Token: 0x04003506 RID: 13574
		public const int NNLIGGHEBFPFieldNumber = 10;

		// Token: 0x04003507 RID: 13575
		private MFDHINNNEGL nNLIGGHEBFP_;
	}
}
