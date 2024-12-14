using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000161 RID: 353
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CancelCacheNotifyScRsp : IMessage<CancelCacheNotifyScRsp>, IMessage, IEquatable<CancelCacheNotifyScRsp>, IDeepCloneable<CancelCacheNotifyScRsp>, IBufferMessage
	{
		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x0002E224 File Offset: 0x0002C424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CancelCacheNotifyScRsp> Parser
		{
			get
			{
				return CancelCacheNotifyScRsp._parser;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000FC3 RID: 4035 RVA: 0x0002E22B File Offset: 0x0002C42B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CancelCacheNotifyScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x0002E23D File Offset: 0x0002C43D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CancelCacheNotifyScRsp.Descriptor;
			}
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x0002E244 File Offset: 0x0002C444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelCacheNotifyScRsp()
		{
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x0002E24C File Offset: 0x0002C44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelCacheNotifyScRsp(CancelCacheNotifyScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x0002E271 File Offset: 0x0002C471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelCacheNotifyScRsp Clone()
		{
			return new CancelCacheNotifyScRsp(this);
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x0002E279 File Offset: 0x0002C479
		// (set) Token: 0x06000FC9 RID: 4041 RVA: 0x0002E281 File Offset: 0x0002C481
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

		// Token: 0x06000FCA RID: 4042 RVA: 0x0002E28A File Offset: 0x0002C48A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CancelCacheNotifyScRsp);
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x0002E298 File Offset: 0x0002C498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CancelCacheNotifyScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x0002E2C8 File Offset: 0x0002C4C8
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

		// Token: 0x06000FCD RID: 4045 RVA: 0x0002E307 File Offset: 0x0002C507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x0002E30F File Offset: 0x0002C50F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x0002E318 File Offset: 0x0002C518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x0002E34C File Offset: 0x0002C54C
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

		// Token: 0x06000FD1 RID: 4049 RVA: 0x0002E38A File Offset: 0x0002C58A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CancelCacheNotifyScRsp other)
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

		// Token: 0x06000FD2 RID: 4050 RVA: 0x0002E3BB File Offset: 0x0002C5BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x0002E3C4 File Offset: 0x0002C5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040006B8 RID: 1720
		private static readonly MessageParser<CancelCacheNotifyScRsp> _parser = new MessageParser<CancelCacheNotifyScRsp>(() => new CancelCacheNotifyScRsp());

		// Token: 0x040006B9 RID: 1721
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006BA RID: 1722
		public const int RetcodeFieldNumber = 14;

		// Token: 0x040006BB RID: 1723
		private uint retcode_;
	}
}
