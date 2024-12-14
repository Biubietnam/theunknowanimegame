using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000073 RID: 115
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AFFKECMGPEI : IMessage<AFFKECMGPEI>, IMessage, IEquatable<AFFKECMGPEI>, IDeepCloneable<AFFKECMGPEI>, IBufferMessage
	{
		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x0000E1FC File Offset: 0x0000C3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AFFKECMGPEI> Parser
		{
			get
			{
				return AFFKECMGPEI._parser;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x0000E203 File Offset: 0x0000C403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AFFKECMGPEIReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x0000E215 File Offset: 0x0000C415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AFFKECMGPEI.Descriptor;
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0000E21C File Offset: 0x0000C41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AFFKECMGPEI()
		{
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0000E224 File Offset: 0x0000C424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AFFKECMGPEI(AFFKECMGPEI other) : this()
		{
			this.hAIDICOCIOL_ = ((other.hAIDICOCIOL_ != null) ? other.hAIDICOCIOL_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0000E259 File Offset: 0x0000C459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AFFKECMGPEI Clone()
		{
			return new AFFKECMGPEI(this);
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x0000E261 File Offset: 0x0000C461
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x0000E269 File Offset: 0x0000C469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NFOGHDHIDNH HAIDICOCIOL
		{
			get
			{
				return this.hAIDICOCIOL_;
			}
			set
			{
				this.hAIDICOCIOL_ = value;
			}
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0000E272 File Offset: 0x0000C472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AFFKECMGPEI);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0000E280 File Offset: 0x0000C480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AFFKECMGPEI other)
		{
			return other != null && (other == this || (object.Equals(this.HAIDICOCIOL, other.HAIDICOCIOL) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0000E2B4 File Offset: 0x0000C4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.hAIDICOCIOL_ != null)
			{
				num ^= this.HAIDICOCIOL.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0000E2F0 File Offset: 0x0000C4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0000E2F8 File Offset: 0x0000C4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0000E301 File Offset: 0x0000C501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.hAIDICOCIOL_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.HAIDICOCIOL);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0000E334 File Offset: 0x0000C534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.hAIDICOCIOL_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HAIDICOCIOL);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0000E374 File Offset: 0x0000C574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AFFKECMGPEI other)
		{
			if (other == null)
			{
				return;
			}
			if (other.hAIDICOCIOL_ != null)
			{
				if (this.hAIDICOCIOL_ == null)
				{
					this.HAIDICOCIOL = new NFOGHDHIDNH();
				}
				this.HAIDICOCIOL.MergeFrom(other.HAIDICOCIOL);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0000E3C8 File Offset: 0x0000C5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0000E3D4 File Offset: 0x0000C5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.hAIDICOCIOL_ == null)
					{
						this.HAIDICOCIOL = new NFOGHDHIDNH();
					}
					input.ReadMessage(this.HAIDICOCIOL);
				}
			}
		}

		// Token: 0x040001C7 RID: 455
		private static readonly MessageParser<AFFKECMGPEI> _parser = new MessageParser<AFFKECMGPEI>(() => new AFFKECMGPEI());

		// Token: 0x040001C8 RID: 456
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001C9 RID: 457
		public const int HAIDICOCIOLFieldNumber = 2;

		// Token: 0x040001CA RID: 458
		private NFOGHDHIDNH hAIDICOCIOL_;
	}
}
