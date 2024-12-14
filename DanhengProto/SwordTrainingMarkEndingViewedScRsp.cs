using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200123B RID: 4667
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingMarkEndingViewedScRsp : IMessage<SwordTrainingMarkEndingViewedScRsp>, IMessage, IEquatable<SwordTrainingMarkEndingViewedScRsp>, IDeepCloneable<SwordTrainingMarkEndingViewedScRsp>, IBufferMessage
	{
		// Token: 0x17003ABD RID: 15037
		// (get) Token: 0x0600D074 RID: 53364 RVA: 0x0022E25D File Offset: 0x0022C45D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingMarkEndingViewedScRsp> Parser
		{
			get
			{
				return SwordTrainingMarkEndingViewedScRsp._parser;
			}
		}

		// Token: 0x17003ABE RID: 15038
		// (get) Token: 0x0600D075 RID: 53365 RVA: 0x0022E264 File Offset: 0x0022C464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingMarkEndingViewedScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003ABF RID: 15039
		// (get) Token: 0x0600D076 RID: 53366 RVA: 0x0022E276 File Offset: 0x0022C476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingMarkEndingViewedScRsp.Descriptor;
			}
		}

		// Token: 0x0600D077 RID: 53367 RVA: 0x0022E27D File Offset: 0x0022C47D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingMarkEndingViewedScRsp()
		{
		}

		// Token: 0x0600D078 RID: 53368 RVA: 0x0022E285 File Offset: 0x0022C485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingMarkEndingViewedScRsp(SwordTrainingMarkEndingViewedScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D079 RID: 53369 RVA: 0x0022E2AA File Offset: 0x0022C4AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingMarkEndingViewedScRsp Clone()
		{
			return new SwordTrainingMarkEndingViewedScRsp(this);
		}

		// Token: 0x17003AC0 RID: 15040
		// (get) Token: 0x0600D07A RID: 53370 RVA: 0x0022E2B2 File Offset: 0x0022C4B2
		// (set) Token: 0x0600D07B RID: 53371 RVA: 0x0022E2BA File Offset: 0x0022C4BA
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

		// Token: 0x0600D07C RID: 53372 RVA: 0x0022E2C3 File Offset: 0x0022C4C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingMarkEndingViewedScRsp);
		}

		// Token: 0x0600D07D RID: 53373 RVA: 0x0022E2D1 File Offset: 0x0022C4D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingMarkEndingViewedScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D07E RID: 53374 RVA: 0x0022E300 File Offset: 0x0022C500
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

		// Token: 0x0600D07F RID: 53375 RVA: 0x0022E33F File Offset: 0x0022C53F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D080 RID: 53376 RVA: 0x0022E347 File Offset: 0x0022C547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D081 RID: 53377 RVA: 0x0022E350 File Offset: 0x0022C550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D082 RID: 53378 RVA: 0x0022E384 File Offset: 0x0022C584
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

		// Token: 0x0600D083 RID: 53379 RVA: 0x0022E3C2 File Offset: 0x0022C5C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingMarkEndingViewedScRsp other)
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

		// Token: 0x0600D084 RID: 53380 RVA: 0x0022E3F3 File Offset: 0x0022C5F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D085 RID: 53381 RVA: 0x0022E3FC File Offset: 0x0022C5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040053C7 RID: 21447
		private static readonly MessageParser<SwordTrainingMarkEndingViewedScRsp> _parser = new MessageParser<SwordTrainingMarkEndingViewedScRsp>(() => new SwordTrainingMarkEndingViewedScRsp());

		// Token: 0x040053C8 RID: 21448
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053C9 RID: 21449
		public const int RetcodeFieldNumber = 2;

		// Token: 0x040053CA RID: 21450
		private uint retcode_;
	}
}
