using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001233 RID: 4659
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingGiveUpGameScRsp : IMessage<SwordTrainingGiveUpGameScRsp>, IMessage, IEquatable<SwordTrainingGiveUpGameScRsp>, IDeepCloneable<SwordTrainingGiveUpGameScRsp>, IBufferMessage
	{
		// Token: 0x17003AA9 RID: 15017
		// (get) Token: 0x0600D020 RID: 53280 RVA: 0x0022D88C File Offset: 0x0022BA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingGiveUpGameScRsp> Parser
		{
			get
			{
				return SwordTrainingGiveUpGameScRsp._parser;
			}
		}

		// Token: 0x17003AAA RID: 15018
		// (get) Token: 0x0600D021 RID: 53281 RVA: 0x0022D893 File Offset: 0x0022BA93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingGiveUpGameScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003AAB RID: 15019
		// (get) Token: 0x0600D022 RID: 53282 RVA: 0x0022D8A5 File Offset: 0x0022BAA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingGiveUpGameScRsp.Descriptor;
			}
		}

		// Token: 0x0600D023 RID: 53283 RVA: 0x0022D8AC File Offset: 0x0022BAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingGiveUpGameScRsp()
		{
		}

		// Token: 0x0600D024 RID: 53284 RVA: 0x0022D8B4 File Offset: 0x0022BAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingGiveUpGameScRsp(SwordTrainingGiveUpGameScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D025 RID: 53285 RVA: 0x0022D8D9 File Offset: 0x0022BAD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingGiveUpGameScRsp Clone()
		{
			return new SwordTrainingGiveUpGameScRsp(this);
		}

		// Token: 0x17003AAC RID: 15020
		// (get) Token: 0x0600D026 RID: 53286 RVA: 0x0022D8E1 File Offset: 0x0022BAE1
		// (set) Token: 0x0600D027 RID: 53287 RVA: 0x0022D8E9 File Offset: 0x0022BAE9
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

		// Token: 0x0600D028 RID: 53288 RVA: 0x0022D8F2 File Offset: 0x0022BAF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingGiveUpGameScRsp);
		}

		// Token: 0x0600D029 RID: 53289 RVA: 0x0022D900 File Offset: 0x0022BB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingGiveUpGameScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D02A RID: 53290 RVA: 0x0022D930 File Offset: 0x0022BB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600D02B RID: 53291 RVA: 0x0022D96F File Offset: 0x0022BB6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D02C RID: 53292 RVA: 0x0022D977 File Offset: 0x0022BB77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D02D RID: 53293 RVA: 0x0022D980 File Offset: 0x0022BB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D02E RID: 53294 RVA: 0x0022D9B4 File Offset: 0x0022BBB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600D02F RID: 53295 RVA: 0x0022D9F2 File Offset: 0x0022BBF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingGiveUpGameScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D030 RID: 53296 RVA: 0x0022DA23 File Offset: 0x0022BC23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D031 RID: 53297 RVA: 0x0022DA2C File Offset: 0x0022BC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040053B3 RID: 21427
		private static readonly MessageParser<SwordTrainingGiveUpGameScRsp> _parser = new MessageParser<SwordTrainingGiveUpGameScRsp>(() => new SwordTrainingGiveUpGameScRsp());

		// Token: 0x040053B4 RID: 21428
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053B5 RID: 21429
		public const int RetcodeFieldNumber = 4;

		// Token: 0x040053B6 RID: 21430
		private uint retcode_;
	}
}
