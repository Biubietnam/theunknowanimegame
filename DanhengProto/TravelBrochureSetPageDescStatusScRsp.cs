using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200138D RID: 5005
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TravelBrochureSetPageDescStatusScRsp : IMessage<TravelBrochureSetPageDescStatusScRsp>, IMessage, IEquatable<TravelBrochureSetPageDescStatusScRsp>, IDeepCloneable<TravelBrochureSetPageDescStatusScRsp>, IBufferMessage
	{
		// Token: 0x17003EB0 RID: 16048
		// (get) Token: 0x0600DF45 RID: 57157 RVA: 0x00251FFD File Offset: 0x002501FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TravelBrochureSetPageDescStatusScRsp> Parser
		{
			get
			{
				return TravelBrochureSetPageDescStatusScRsp._parser;
			}
		}

		// Token: 0x17003EB1 RID: 16049
		// (get) Token: 0x0600DF46 RID: 57158 RVA: 0x00252004 File Offset: 0x00250204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TravelBrochureSetPageDescStatusScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003EB2 RID: 16050
		// (get) Token: 0x0600DF47 RID: 57159 RVA: 0x00252016 File Offset: 0x00250216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TravelBrochureSetPageDescStatusScRsp.Descriptor;
			}
		}

		// Token: 0x0600DF48 RID: 57160 RVA: 0x0025201D File Offset: 0x0025021D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureSetPageDescStatusScRsp()
		{
		}

		// Token: 0x0600DF49 RID: 57161 RVA: 0x00252025 File Offset: 0x00250225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureSetPageDescStatusScRsp(TravelBrochureSetPageDescStatusScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DF4A RID: 57162 RVA: 0x0025204A File Offset: 0x0025024A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureSetPageDescStatusScRsp Clone()
		{
			return new TravelBrochureSetPageDescStatusScRsp(this);
		}

		// Token: 0x17003EB3 RID: 16051
		// (get) Token: 0x0600DF4B RID: 57163 RVA: 0x00252052 File Offset: 0x00250252
		// (set) Token: 0x0600DF4C RID: 57164 RVA: 0x0025205A File Offset: 0x0025025A
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

		// Token: 0x0600DF4D RID: 57165 RVA: 0x00252063 File Offset: 0x00250263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TravelBrochureSetPageDescStatusScRsp);
		}

		// Token: 0x0600DF4E RID: 57166 RVA: 0x00252071 File Offset: 0x00250271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TravelBrochureSetPageDescStatusScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DF4F RID: 57167 RVA: 0x002520A0 File Offset: 0x002502A0
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

		// Token: 0x0600DF50 RID: 57168 RVA: 0x002520DF File Offset: 0x002502DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DF51 RID: 57169 RVA: 0x002520E7 File Offset: 0x002502E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DF52 RID: 57170 RVA: 0x002520F0 File Offset: 0x002502F0
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

		// Token: 0x0600DF53 RID: 57171 RVA: 0x00252124 File Offset: 0x00250324
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

		// Token: 0x0600DF54 RID: 57172 RVA: 0x00252162 File Offset: 0x00250362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TravelBrochureSetPageDescStatusScRsp other)
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

		// Token: 0x0600DF55 RID: 57173 RVA: 0x00252193 File Offset: 0x00250393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DF56 RID: 57174 RVA: 0x0025219C File Offset: 0x0025039C
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

		// Token: 0x040058B3 RID: 22707
		private static readonly MessageParser<TravelBrochureSetPageDescStatusScRsp> _parser = new MessageParser<TravelBrochureSetPageDescStatusScRsp>(() => new TravelBrochureSetPageDescStatusScRsp());

		// Token: 0x040058B4 RID: 22708
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058B5 RID: 22709
		public const int RetcodeFieldNumber = 14;

		// Token: 0x040058B6 RID: 22710
		private uint retcode_;
	}
}
