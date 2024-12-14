using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BC7 RID: 3015
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MuseumRandomEventSelectScRsp : IMessage<MuseumRandomEventSelectScRsp>, IMessage, IEquatable<MuseumRandomEventSelectScRsp>, IDeepCloneable<MuseumRandomEventSelectScRsp>, IBufferMessage
	{
		// Token: 0x1700256E RID: 9582
		// (get) Token: 0x06008578 RID: 34168 RVA: 0x001606F5 File Offset: 0x0015E8F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MuseumRandomEventSelectScRsp> Parser
		{
			get
			{
				return MuseumRandomEventSelectScRsp._parser;
			}
		}

		// Token: 0x1700256F RID: 9583
		// (get) Token: 0x06008579 RID: 34169 RVA: 0x001606FC File Offset: 0x0015E8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MuseumRandomEventSelectScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002570 RID: 9584
		// (get) Token: 0x0600857A RID: 34170 RVA: 0x0016070E File Offset: 0x0015E90E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MuseumRandomEventSelectScRsp.Descriptor;
			}
		}

		// Token: 0x0600857B RID: 34171 RVA: 0x00160715 File Offset: 0x0015E915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumRandomEventSelectScRsp()
		{
		}

		// Token: 0x0600857C RID: 34172 RVA: 0x0016071D File Offset: 0x0015E91D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumRandomEventSelectScRsp(MuseumRandomEventSelectScRsp other) : this()
		{
			this.eventId_ = other.eventId_;
			this.retcode_ = other.retcode_;
			this.aPOELPDBOHG_ = other.aPOELPDBOHG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600857D RID: 34173 RVA: 0x0016075A File Offset: 0x0015E95A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumRandomEventSelectScRsp Clone()
		{
			return new MuseumRandomEventSelectScRsp(this);
		}

		// Token: 0x17002571 RID: 9585
		// (get) Token: 0x0600857E RID: 34174 RVA: 0x00160762 File Offset: 0x0015E962
		// (set) Token: 0x0600857F RID: 34175 RVA: 0x0016076A File Offset: 0x0015E96A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x17002572 RID: 9586
		// (get) Token: 0x06008580 RID: 34176 RVA: 0x00160773 File Offset: 0x0015E973
		// (set) Token: 0x06008581 RID: 34177 RVA: 0x0016077B File Offset: 0x0015E97B
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

		// Token: 0x17002573 RID: 9587
		// (get) Token: 0x06008582 RID: 34178 RVA: 0x00160784 File Offset: 0x0015E984
		// (set) Token: 0x06008583 RID: 34179 RVA: 0x0016078C File Offset: 0x0015E98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint APOELPDBOHG
		{
			get
			{
				return this.aPOELPDBOHG_;
			}
			set
			{
				this.aPOELPDBOHG_ = value;
			}
		}

		// Token: 0x06008584 RID: 34180 RVA: 0x00160795 File Offset: 0x0015E995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MuseumRandomEventSelectScRsp);
		}

		// Token: 0x06008585 RID: 34181 RVA: 0x001607A4 File Offset: 0x0015E9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MuseumRandomEventSelectScRsp other)
		{
			return other != null && (other == this || (this.EventId == other.EventId && this.Retcode == other.Retcode && this.APOELPDBOHG == other.APOELPDBOHG && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008586 RID: 34182 RVA: 0x00160800 File Offset: 0x0015EA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventId != 0U)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.APOELPDBOHG != 0U)
			{
				num ^= this.APOELPDBOHG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008587 RID: 34183 RVA: 0x00160871 File Offset: 0x0015EA71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008588 RID: 34184 RVA: 0x00160879 File Offset: 0x0015EA79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008589 RID: 34185 RVA: 0x00160884 File Offset: 0x0015EA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.APOELPDBOHG != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.APOELPDBOHG);
			}
			if (this.EventId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.EventId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600858A RID: 34186 RVA: 0x001608F8 File Offset: 0x0015EAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.APOELPDBOHG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.APOELPDBOHG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600858B RID: 34187 RVA: 0x00160968 File Offset: 0x0015EB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MuseumRandomEventSelectScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventId != 0U)
			{
				this.EventId = other.EventId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.APOELPDBOHG != 0U)
			{
				this.APOELPDBOHG = other.APOELPDBOHG;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600858C RID: 34188 RVA: 0x001609CC File Offset: 0x0015EBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600858D RID: 34189 RVA: 0x001609D8 File Offset: 0x0015EBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EventId = input.ReadUInt32();
						}
					}
					else
					{
						this.APOELPDBOHG = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003321 RID: 13089
		private static readonly MessageParser<MuseumRandomEventSelectScRsp> _parser = new MessageParser<MuseumRandomEventSelectScRsp>(() => new MuseumRandomEventSelectScRsp());

		// Token: 0x04003322 RID: 13090
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003323 RID: 13091
		public const int EventIdFieldNumber = 15;

		// Token: 0x04003324 RID: 13092
		private uint eventId_;

		// Token: 0x04003325 RID: 13093
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04003326 RID: 13094
		private uint retcode_;

		// Token: 0x04003327 RID: 13095
		public const int APOELPDBOHGFieldNumber = 2;

		// Token: 0x04003328 RID: 13096
		private uint aPOELPDBOHG_;
	}
}
