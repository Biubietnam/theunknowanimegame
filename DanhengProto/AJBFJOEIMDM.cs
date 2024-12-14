using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000079 RID: 121
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AJBFJOEIMDM : IMessage<AJBFJOEIMDM>, IMessage, IEquatable<AJBFJOEIMDM>, IDeepCloneable<AJBFJOEIMDM>, IBufferMessage
	{
		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x0000F150 File Offset: 0x0000D350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AJBFJOEIMDM> Parser
		{
			get
			{
				return AJBFJOEIMDM._parser;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x0000F157 File Offset: 0x0000D357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AJBFJOEIMDMReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x0000F169 File Offset: 0x0000D369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AJBFJOEIMDM.Descriptor;
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0000F170 File Offset: 0x0000D370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AJBFJOEIMDM()
		{
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0000F178 File Offset: 0x0000D378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AJBFJOEIMDM(AJBFJOEIMDM other) : this()
		{
			this.isWin_ = other.isWin_;
			this.fMKOBADLNKI_ = other.fMKOBADLNKI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0000F1A9 File Offset: 0x0000D3A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AJBFJOEIMDM Clone()
		{
			return new AJBFJOEIMDM(this);
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x0000F1B1 File Offset: 0x0000D3B1
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x0000F1B9 File Offset: 0x0000D3B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsWin
		{
			get
			{
				return this.isWin_;
			}
			set
			{
				this.isWin_ = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x0000F1C2 File Offset: 0x0000D3C2
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x0000F1CA File Offset: 0x0000D3CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FMKOBADLNKI
		{
			get
			{
				return this.fMKOBADLNKI_;
			}
			set
			{
				this.fMKOBADLNKI_ = value;
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0000F1D3 File Offset: 0x0000D3D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AJBFJOEIMDM);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0000F1E1 File Offset: 0x0000D3E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AJBFJOEIMDM other)
		{
			return other != null && (other == this || (this.IsWin == other.IsWin && this.FMKOBADLNKI == other.FMKOBADLNKI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0000F220 File Offset: 0x0000D420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsWin)
			{
				num ^= this.IsWin.GetHashCode();
			}
			if (this.FMKOBADLNKI != 0U)
			{
				num ^= this.FMKOBADLNKI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0000F278 File Offset: 0x0000D478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0000F280 File Offset: 0x0000D480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0000F28C File Offset: 0x0000D48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsWin)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsWin);
			}
			if (this.FMKOBADLNKI != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.FMKOBADLNKI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0000F2E8 File Offset: 0x0000D4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsWin)
			{
				num += 2;
			}
			if (this.FMKOBADLNKI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FMKOBADLNKI);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x0000F334 File Offset: 0x0000D534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AJBFJOEIMDM other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsWin)
			{
				this.IsWin = other.IsWin;
			}
			if (other.FMKOBADLNKI != 0U)
			{
				this.FMKOBADLNKI = other.FMKOBADLNKI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0000F384 File Offset: 0x0000D584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0000F390 File Offset: 0x0000D590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FMKOBADLNKI = input.ReadUInt32();
					}
				}
				else
				{
					this.IsWin = input.ReadBool();
				}
			}
		}

		// Token: 0x040001EC RID: 492
		private static readonly MessageParser<AJBFJOEIMDM> _parser = new MessageParser<AJBFJOEIMDM>(() => new AJBFJOEIMDM());

		// Token: 0x040001ED RID: 493
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001EE RID: 494
		public const int IsWinFieldNumber = 14;

		// Token: 0x040001EF RID: 495
		private bool isWin_;

		// Token: 0x040001F0 RID: 496
		public const int FMKOBADLNKIFieldNumber = 15;

		// Token: 0x040001F1 RID: 497
		private uint fMKOBADLNKI_;
	}
}
