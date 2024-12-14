using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DC3 RID: 3523
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ReportPlayerScRsp : IMessage<ReportPlayerScRsp>, IMessage, IEquatable<ReportPlayerScRsp>, IDeepCloneable<ReportPlayerScRsp>, IBufferMessage
	{
		// Token: 0x17002C7D RID: 11389
		// (get) Token: 0x06009D88 RID: 40328 RVA: 0x001A3D00 File Offset: 0x001A1F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ReportPlayerScRsp> Parser
		{
			get
			{
				return ReportPlayerScRsp._parser;
			}
		}

		// Token: 0x17002C7E RID: 11390
		// (get) Token: 0x06009D89 RID: 40329 RVA: 0x001A3D07 File Offset: 0x001A1F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReportPlayerScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C7F RID: 11391
		// (get) Token: 0x06009D8A RID: 40330 RVA: 0x001A3D19 File Offset: 0x001A1F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReportPlayerScRsp.Descriptor;
			}
		}

		// Token: 0x06009D8B RID: 40331 RVA: 0x001A3D20 File Offset: 0x001A1F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportPlayerScRsp()
		{
		}

		// Token: 0x06009D8C RID: 40332 RVA: 0x001A3D28 File Offset: 0x001A1F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportPlayerScRsp(ReportPlayerScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D8D RID: 40333 RVA: 0x001A3D4D File Offset: 0x001A1F4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportPlayerScRsp Clone()
		{
			return new ReportPlayerScRsp(this);
		}

		// Token: 0x17002C80 RID: 11392
		// (get) Token: 0x06009D8E RID: 40334 RVA: 0x001A3D55 File Offset: 0x001A1F55
		// (set) Token: 0x06009D8F RID: 40335 RVA: 0x001A3D5D File Offset: 0x001A1F5D
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

		// Token: 0x06009D90 RID: 40336 RVA: 0x001A3D66 File Offset: 0x001A1F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReportPlayerScRsp);
		}

		// Token: 0x06009D91 RID: 40337 RVA: 0x001A3D74 File Offset: 0x001A1F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReportPlayerScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009D92 RID: 40338 RVA: 0x001A3DA4 File Offset: 0x001A1FA4
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

		// Token: 0x06009D93 RID: 40339 RVA: 0x001A3DE3 File Offset: 0x001A1FE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009D94 RID: 40340 RVA: 0x001A3DEB File Offset: 0x001A1FEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D95 RID: 40341 RVA: 0x001A3DF4 File Offset: 0x001A1FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D96 RID: 40342 RVA: 0x001A3E28 File Offset: 0x001A2028
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

		// Token: 0x06009D97 RID: 40343 RVA: 0x001A3E66 File Offset: 0x001A2066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReportPlayerScRsp other)
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

		// Token: 0x06009D98 RID: 40344 RVA: 0x001A3E97 File Offset: 0x001A2097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D99 RID: 40345 RVA: 0x001A3EA0 File Offset: 0x001A20A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003D48 RID: 15688
		private static readonly MessageParser<ReportPlayerScRsp> _parser = new MessageParser<ReportPlayerScRsp>(() => new ReportPlayerScRsp());

		// Token: 0x04003D49 RID: 15689
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D4A RID: 15690
		public const int RetcodeFieldNumber = 13;

		// Token: 0x04003D4B RID: 15691
		private uint retcode_;
	}
}
