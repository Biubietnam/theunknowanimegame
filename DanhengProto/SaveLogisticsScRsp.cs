using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001049 RID: 4169
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SaveLogisticsScRsp : IMessage<SaveLogisticsScRsp>, IMessage, IEquatable<SaveLogisticsScRsp>, IDeepCloneable<SaveLogisticsScRsp>, IBufferMessage
	{
		// Token: 0x17003441 RID: 13377
		// (get) Token: 0x0600B975 RID: 47477 RVA: 0x001F1D5D File Offset: 0x001EFF5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SaveLogisticsScRsp> Parser
		{
			get
			{
				return SaveLogisticsScRsp._parser;
			}
		}

		// Token: 0x17003442 RID: 13378
		// (get) Token: 0x0600B976 RID: 47478 RVA: 0x001F1D64 File Offset: 0x001EFF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SaveLogisticsScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003443 RID: 13379
		// (get) Token: 0x0600B977 RID: 47479 RVA: 0x001F1D76 File Offset: 0x001EFF76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SaveLogisticsScRsp.Descriptor;
			}
		}

		// Token: 0x0600B978 RID: 47480 RVA: 0x001F1D7D File Offset: 0x001EFF7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SaveLogisticsScRsp()
		{
		}

		// Token: 0x0600B979 RID: 47481 RVA: 0x001F1D90 File Offset: 0x001EFF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SaveLogisticsScRsp(SaveLogisticsScRsp other) : this()
		{
			this.aACPHJGMNDF_ = other.aACPHJGMNDF_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B97A RID: 47482 RVA: 0x001F1DC6 File Offset: 0x001EFFC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SaveLogisticsScRsp Clone()
		{
			return new SaveLogisticsScRsp(this);
		}

		// Token: 0x17003444 RID: 13380
		// (get) Token: 0x0600B97B RID: 47483 RVA: 0x001F1DCE File Offset: 0x001EFFCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HGGCNNJOEPH> AACPHJGMNDF
		{
			get
			{
				return this.aACPHJGMNDF_;
			}
		}

		// Token: 0x17003445 RID: 13381
		// (get) Token: 0x0600B97C RID: 47484 RVA: 0x001F1DD6 File Offset: 0x001EFFD6
		// (set) Token: 0x0600B97D RID: 47485 RVA: 0x001F1DDE File Offset: 0x001EFFDE
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

		// Token: 0x0600B97E RID: 47486 RVA: 0x001F1DE7 File Offset: 0x001EFFE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SaveLogisticsScRsp);
		}

		// Token: 0x0600B97F RID: 47487 RVA: 0x001F1DF8 File Offset: 0x001EFFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SaveLogisticsScRsp other)
		{
			return other != null && (other == this || (this.aACPHJGMNDF_.Equals(other.aACPHJGMNDF_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B980 RID: 47488 RVA: 0x001F1E48 File Offset: 0x001F0048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aACPHJGMNDF_.GetHashCode();
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

		// Token: 0x0600B981 RID: 47489 RVA: 0x001F1E95 File Offset: 0x001F0095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B982 RID: 47490 RVA: 0x001F1E9D File Offset: 0x001F009D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B983 RID: 47491 RVA: 0x001F1EA8 File Offset: 0x001F00A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.aACPHJGMNDF_.WriteTo(ref output, SaveLogisticsScRsp._repeated_aACPHJGMNDF_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B984 RID: 47492 RVA: 0x001F1EF8 File Offset: 0x001F00F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aACPHJGMNDF_.CalculateSize(SaveLogisticsScRsp._repeated_aACPHJGMNDF_codec);
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

		// Token: 0x0600B985 RID: 47493 RVA: 0x001F1F4C File Offset: 0x001F014C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SaveLogisticsScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.aACPHJGMNDF_.Add(other.aACPHJGMNDF_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B986 RID: 47494 RVA: 0x001F1F99 File Offset: 0x001F0199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B987 RID: 47495 RVA: 0x001F1FA4 File Offset: 0x001F01A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 58U)
				{
					if (num != 120U)
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
					this.aACPHJGMNDF_.AddEntriesFrom(ref input, SaveLogisticsScRsp._repeated_aACPHJGMNDF_codec);
				}
			}
		}

		// Token: 0x04004B1A RID: 19226
		private static readonly MessageParser<SaveLogisticsScRsp> _parser = new MessageParser<SaveLogisticsScRsp>(() => new SaveLogisticsScRsp());

		// Token: 0x04004B1B RID: 19227
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B1C RID: 19228
		public const int AACPHJGMNDFFieldNumber = 7;

		// Token: 0x04004B1D RID: 19229
		private static readonly FieldCodec<HGGCNNJOEPH> _repeated_aACPHJGMNDF_codec = FieldCodec.ForMessage<HGGCNNJOEPH>(58U, HGGCNNJOEPH.Parser);

		// Token: 0x04004B1E RID: 19230
		private readonly RepeatedField<HGGCNNJOEPH> aACPHJGMNDF_ = new RepeatedField<HGGCNNJOEPH>();

		// Token: 0x04004B1F RID: 19231
		public const int RetcodeFieldNumber = 15;

		// Token: 0x04004B20 RID: 19232
		private uint retcode_;
	}
}
