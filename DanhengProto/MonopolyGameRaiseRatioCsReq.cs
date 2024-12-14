using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B37 RID: 2871
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyGameRaiseRatioCsReq : IMessage<MonopolyGameRaiseRatioCsReq>, IMessage, IEquatable<MonopolyGameRaiseRatioCsReq>, IDeepCloneable<MonopolyGameRaiseRatioCsReq>, IBufferMessage
	{
		// Token: 0x170023A4 RID: 9124
		// (get) Token: 0x06007F12 RID: 32530 RVA: 0x0014FCD0 File Offset: 0x0014DED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyGameRaiseRatioCsReq> Parser
		{
			get
			{
				return MonopolyGameRaiseRatioCsReq._parser;
			}
		}

		// Token: 0x170023A5 RID: 9125
		// (get) Token: 0x06007F13 RID: 32531 RVA: 0x0014FCD7 File Offset: 0x0014DED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyGameRaiseRatioCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170023A6 RID: 9126
		// (get) Token: 0x06007F14 RID: 32532 RVA: 0x0014FCE9 File Offset: 0x0014DEE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyGameRaiseRatioCsReq.Descriptor;
			}
		}

		// Token: 0x06007F15 RID: 32533 RVA: 0x0014FCF0 File Offset: 0x0014DEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGameRaiseRatioCsReq()
		{
		}

		// Token: 0x06007F16 RID: 32534 RVA: 0x0014FCF8 File Offset: 0x0014DEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGameRaiseRatioCsReq(MonopolyGameRaiseRatioCsReq other) : this()
		{
			this.gFDGGCBGGGD_ = other.gFDGGCBGGGD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F17 RID: 32535 RVA: 0x0014FD1D File Offset: 0x0014DF1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGameRaiseRatioCsReq Clone()
		{
			return new MonopolyGameRaiseRatioCsReq(this);
		}

		// Token: 0x170023A7 RID: 9127
		// (get) Token: 0x06007F18 RID: 32536 RVA: 0x0014FD25 File Offset: 0x0014DF25
		// (set) Token: 0x06007F19 RID: 32537 RVA: 0x0014FD2D File Offset: 0x0014DF2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GFDGGCBGGGD
		{
			get
			{
				return this.gFDGGCBGGGD_;
			}
			set
			{
				this.gFDGGCBGGGD_ = value;
			}
		}

		// Token: 0x06007F1A RID: 32538 RVA: 0x0014FD36 File Offset: 0x0014DF36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyGameRaiseRatioCsReq);
		}

		// Token: 0x06007F1B RID: 32539 RVA: 0x0014FD44 File Offset: 0x0014DF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyGameRaiseRatioCsReq other)
		{
			return other != null && (other == this || (this.GFDGGCBGGGD == other.GFDGGCBGGGD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007F1C RID: 32540 RVA: 0x0014FD74 File Offset: 0x0014DF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GFDGGCBGGGD != 0U)
			{
				num ^= this.GFDGGCBGGGD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007F1D RID: 32541 RVA: 0x0014FDB3 File Offset: 0x0014DFB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007F1E RID: 32542 RVA: 0x0014FDBB File Offset: 0x0014DFBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F1F RID: 32543 RVA: 0x0014FDC4 File Offset: 0x0014DFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GFDGGCBGGGD != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.GFDGGCBGGGD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007F20 RID: 32544 RVA: 0x0014FDF8 File Offset: 0x0014DFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GFDGGCBGGGD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GFDGGCBGGGD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007F21 RID: 32545 RVA: 0x0014FE36 File Offset: 0x0014E036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyGameRaiseRatioCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GFDGGCBGGGD != 0U)
			{
				this.GFDGGCBGGGD = other.GFDGGCBGGGD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007F22 RID: 32546 RVA: 0x0014FE67 File Offset: 0x0014E067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F23 RID: 32547 RVA: 0x0014FE70 File Offset: 0x0014E070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GFDGGCBGGGD = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040030B1 RID: 12465
		private static readonly MessageParser<MonopolyGameRaiseRatioCsReq> _parser = new MessageParser<MonopolyGameRaiseRatioCsReq>(() => new MonopolyGameRaiseRatioCsReq());

		// Token: 0x040030B2 RID: 12466
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030B3 RID: 12467
		public const int GFDGGCBGGGDFieldNumber = 6;

		// Token: 0x040030B4 RID: 12468
		private uint gFDGGCBGGGD_;
	}
}
