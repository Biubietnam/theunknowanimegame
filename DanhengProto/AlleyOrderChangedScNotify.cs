using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200008B RID: 139
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AlleyOrderChangedScNotify : IMessage<AlleyOrderChangedScNotify>, IMessage, IEquatable<AlleyOrderChangedScNotify>, IDeepCloneable<AlleyOrderChangedScNotify>, IBufferMessage
	{
		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x00010A65 File Offset: 0x0000EC65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AlleyOrderChangedScNotify> Parser
		{
			get
			{
				return AlleyOrderChangedScNotify._parser;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x00010A6C File Offset: 0x0000EC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AlleyOrderChangedScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x00010A7E File Offset: 0x0000EC7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AlleyOrderChangedScNotify.Descriptor;
			}
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00010A85 File Offset: 0x0000EC85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyOrderChangedScNotify()
		{
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00010A8D File Offset: 0x0000EC8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyOrderChangedScNotify(AlleyOrderChangedScNotify other) : this()
		{
			this.pFMJLEDKIMH_ = ((other.pFMJLEDKIMH_ != null) ? other.pFMJLEDKIMH_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00010AC2 File Offset: 0x0000ECC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyOrderChangedScNotify Clone()
		{
			return new AlleyOrderChangedScNotify(this);
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x00010ACA File Offset: 0x0000ECCA
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x00010AD2 File Offset: 0x0000ECD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JCHNGGIIOCD PFMJLEDKIMH
		{
			get
			{
				return this.pFMJLEDKIMH_;
			}
			set
			{
				this.pFMJLEDKIMH_ = value;
			}
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00010ADB File Offset: 0x0000ECDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AlleyOrderChangedScNotify);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00010AE9 File Offset: 0x0000ECE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AlleyOrderChangedScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PFMJLEDKIMH, other.PFMJLEDKIMH) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00010B1C File Offset: 0x0000ED1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.pFMJLEDKIMH_ != null)
			{
				num ^= this.PFMJLEDKIMH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00010B58 File Offset: 0x0000ED58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00010B60 File Offset: 0x0000ED60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00010B69 File Offset: 0x0000ED69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pFMJLEDKIMH_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.PFMJLEDKIMH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00010B9C File Offset: 0x0000ED9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.pFMJLEDKIMH_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PFMJLEDKIMH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00010BDC File Offset: 0x0000EDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AlleyOrderChangedScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.pFMJLEDKIMH_ != null)
			{
				if (this.pFMJLEDKIMH_ == null)
				{
					this.PFMJLEDKIMH = new JCHNGGIIOCD();
				}
				this.PFMJLEDKIMH.MergeFrom(other.PFMJLEDKIMH);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00010C30 File Offset: 0x0000EE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00010C3C File Offset: 0x0000EE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.pFMJLEDKIMH_ == null)
					{
						this.PFMJLEDKIMH = new JCHNGGIIOCD();
					}
					input.ReadMessage(this.PFMJLEDKIMH);
				}
			}
		}

		// Token: 0x04000226 RID: 550
		private static readonly MessageParser<AlleyOrderChangedScNotify> _parser = new MessageParser<AlleyOrderChangedScNotify>(() => new AlleyOrderChangedScNotify());

		// Token: 0x04000227 RID: 551
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000228 RID: 552
		public const int PFMJLEDKIMHFieldNumber = 6;

		// Token: 0x04000229 RID: 553
		private JCHNGGIIOCD pFMJLEDKIMH_;
	}
}
