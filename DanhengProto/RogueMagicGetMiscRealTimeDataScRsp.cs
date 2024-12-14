using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EE1 RID: 3809
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicGetMiscRealTimeDataScRsp : IMessage<RogueMagicGetMiscRealTimeDataScRsp>, IMessage, IEquatable<RogueMagicGetMiscRealTimeDataScRsp>, IDeepCloneable<RogueMagicGetMiscRealTimeDataScRsp>, IBufferMessage
	{
		// Token: 0x17003018 RID: 12312
		// (get) Token: 0x0600AA45 RID: 43589 RVA: 0x001CACCB File Offset: 0x001C8ECB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicGetMiscRealTimeDataScRsp> Parser
		{
			get
			{
				return RogueMagicGetMiscRealTimeDataScRsp._parser;
			}
		}

		// Token: 0x17003019 RID: 12313
		// (get) Token: 0x0600AA46 RID: 43590 RVA: 0x001CACD2 File Offset: 0x001C8ED2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicGetMiscRealTimeDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700301A RID: 12314
		// (get) Token: 0x0600AA47 RID: 43591 RVA: 0x001CACE4 File Offset: 0x001C8EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicGetMiscRealTimeDataScRsp.Descriptor;
			}
		}

		// Token: 0x0600AA48 RID: 43592 RVA: 0x001CACEB File Offset: 0x001C8EEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGetMiscRealTimeDataScRsp()
		{
		}

		// Token: 0x0600AA49 RID: 43593 RVA: 0x001CACF4 File Offset: 0x001C8EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGetMiscRealTimeDataScRsp(RogueMagicGetMiscRealTimeDataScRsp other) : this()
		{
			this.lAIOKLJNPFO_ = ((other.lAIOKLJNPFO_ != null) ? other.lAIOKLJNPFO_.Clone() : null);
			this.oGIONEOOFIN_ = ((other.oGIONEOOFIN_ != null) ? other.oGIONEOOFIN_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AA4A RID: 43594 RVA: 0x001CAD5C File Offset: 0x001C8F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGetMiscRealTimeDataScRsp Clone()
		{
			return new RogueMagicGetMiscRealTimeDataScRsp(this);
		}

		// Token: 0x1700301B RID: 12315
		// (get) Token: 0x0600AA4B RID: 43595 RVA: 0x001CAD64 File Offset: 0x001C8F64
		// (set) Token: 0x0600AA4C RID: 43596 RVA: 0x001CAD6C File Offset: 0x001C8F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public COFOFDFPLBE LAIOKLJNPFO
		{
			get
			{
				return this.lAIOKLJNPFO_;
			}
			set
			{
				this.lAIOKLJNPFO_ = value;
			}
		}

		// Token: 0x1700301C RID: 12316
		// (get) Token: 0x0600AA4D RID: 43597 RVA: 0x001CAD75 File Offset: 0x001C8F75
		// (set) Token: 0x0600AA4E RID: 43598 RVA: 0x001CAD7D File Offset: 0x001C8F7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LMPECJMMBHP OGIONEOOFIN
		{
			get
			{
				return this.oGIONEOOFIN_;
			}
			set
			{
				this.oGIONEOOFIN_ = value;
			}
		}

		// Token: 0x1700301D RID: 12317
		// (get) Token: 0x0600AA4F RID: 43599 RVA: 0x001CAD86 File Offset: 0x001C8F86
		// (set) Token: 0x0600AA50 RID: 43600 RVA: 0x001CAD8E File Offset: 0x001C8F8E
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

		// Token: 0x0600AA51 RID: 43601 RVA: 0x001CAD97 File Offset: 0x001C8F97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicGetMiscRealTimeDataScRsp);
		}

		// Token: 0x0600AA52 RID: 43602 RVA: 0x001CADA8 File Offset: 0x001C8FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicGetMiscRealTimeDataScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.LAIOKLJNPFO, other.LAIOKLJNPFO) && object.Equals(this.OGIONEOOFIN, other.OGIONEOOFIN) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AA53 RID: 43603 RVA: 0x001CAE0C File Offset: 0x001C900C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.lAIOKLJNPFO_ != null)
			{
				num ^= this.LAIOKLJNPFO.GetHashCode();
			}
			if (this.oGIONEOOFIN_ != null)
			{
				num ^= this.OGIONEOOFIN.GetHashCode();
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

		// Token: 0x0600AA54 RID: 43604 RVA: 0x001CAE77 File Offset: 0x001C9077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AA55 RID: 43605 RVA: 0x001CAE7F File Offset: 0x001C907F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA56 RID: 43606 RVA: 0x001CAE88 File Offset: 0x001C9088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			if (this.lAIOKLJNPFO_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.LAIOKLJNPFO);
			}
			if (this.oGIONEOOFIN_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.OGIONEOOFIN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AA57 RID: 43607 RVA: 0x001CAF00 File Offset: 0x001C9100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.lAIOKLJNPFO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LAIOKLJNPFO);
			}
			if (this.oGIONEOOFIN_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OGIONEOOFIN);
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

		// Token: 0x0600AA58 RID: 43608 RVA: 0x001CAF70 File Offset: 0x001C9170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicGetMiscRealTimeDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.lAIOKLJNPFO_ != null)
			{
				if (this.lAIOKLJNPFO_ == null)
				{
					this.LAIOKLJNPFO = new COFOFDFPLBE();
				}
				this.LAIOKLJNPFO.MergeFrom(other.LAIOKLJNPFO);
			}
			if (other.oGIONEOOFIN_ != null)
			{
				if (this.oGIONEOOFIN_ == null)
				{
					this.OGIONEOOFIN = new LMPECJMMBHP();
				}
				this.OGIONEOOFIN.MergeFrom(other.OGIONEOOFIN);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AA59 RID: 43609 RVA: 0x001CB004 File Offset: 0x001C9204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AA5A RID: 43610 RVA: 0x001CB010 File Offset: 0x001C9210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 90U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.oGIONEOOFIN_ == null)
							{
								this.OGIONEOOFIN = new LMPECJMMBHP();
							}
							input.ReadMessage(this.OGIONEOOFIN);
						}
					}
					else
					{
						if (this.lAIOKLJNPFO_ == null)
						{
							this.LAIOKLJNPFO = new COFOFDFPLBE();
						}
						input.ReadMessage(this.LAIOKLJNPFO);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004586 RID: 17798
		private static readonly MessageParser<RogueMagicGetMiscRealTimeDataScRsp> _parser = new MessageParser<RogueMagicGetMiscRealTimeDataScRsp>(() => new RogueMagicGetMiscRealTimeDataScRsp());

		// Token: 0x04004587 RID: 17799
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004588 RID: 17800
		public const int LAIOKLJNPFOFieldNumber = 11;

		// Token: 0x04004589 RID: 17801
		private COFOFDFPLBE lAIOKLJNPFO_;

		// Token: 0x0400458A RID: 17802
		public const int OGIONEOOFINFieldNumber = 13;

		// Token: 0x0400458B RID: 17803
		private LMPECJMMBHP oGIONEOOFIN_;

		// Token: 0x0400458C RID: 17804
		public const int RetcodeFieldNumber = 7;

		// Token: 0x0400458D RID: 17805
		private uint retcode_;
	}
}
