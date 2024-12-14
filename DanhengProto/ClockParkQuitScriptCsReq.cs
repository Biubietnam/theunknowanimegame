using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002F9 RID: 761
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClockParkQuitScriptCsReq : IMessage<ClockParkQuitScriptCsReq>, IMessage, IEquatable<ClockParkQuitScriptCsReq>, IDeepCloneable<ClockParkQuitScriptCsReq>, IBufferMessage
	{
		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06002207 RID: 8711 RVA: 0x00061071 File Offset: 0x0005F271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClockParkQuitScriptCsReq> Parser
		{
			get
			{
				return ClockParkQuitScriptCsReq._parser;
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06002208 RID: 8712 RVA: 0x00061078 File Offset: 0x0005F278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClockParkQuitScriptCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06002209 RID: 8713 RVA: 0x0006108A File Offset: 0x0005F28A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClockParkQuitScriptCsReq.Descriptor;
			}
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x00061091 File Offset: 0x0005F291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkQuitScriptCsReq()
		{
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x00061099 File Offset: 0x0005F299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkQuitScriptCsReq(ClockParkQuitScriptCsReq other) : this()
		{
			this.gDGNLHINKBM_ = other.gDGNLHINKBM_;
			this.scriptId_ = other.scriptId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x000610CA File Offset: 0x0005F2CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkQuitScriptCsReq Clone()
		{
			return new ClockParkQuitScriptCsReq(this);
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x0600220D RID: 8717 RVA: 0x000610D2 File Offset: 0x0005F2D2
		// (set) Token: 0x0600220E RID: 8718 RVA: 0x000610DA File Offset: 0x0005F2DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GDGNLHINKBM
		{
			get
			{
				return this.gDGNLHINKBM_;
			}
			set
			{
				this.gDGNLHINKBM_ = value;
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x0600220F RID: 8719 RVA: 0x000610E3 File Offset: 0x0005F2E3
		// (set) Token: 0x06002210 RID: 8720 RVA: 0x000610EB File Offset: 0x0005F2EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScriptId
		{
			get
			{
				return this.scriptId_;
			}
			set
			{
				this.scriptId_ = value;
			}
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x000610F4 File Offset: 0x0005F2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClockParkQuitScriptCsReq);
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x00061102 File Offset: 0x0005F302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClockParkQuitScriptCsReq other)
		{
			return other != null && (other == this || (this.GDGNLHINKBM == other.GDGNLHINKBM && this.ScriptId == other.ScriptId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x00061140 File Offset: 0x0005F340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GDGNLHINKBM)
			{
				num ^= this.GDGNLHINKBM.GetHashCode();
			}
			if (this.ScriptId != 0U)
			{
				num ^= this.ScriptId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x00061198 File Offset: 0x0005F398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x000611A0 File Offset: 0x0005F3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x000611AC File Offset: 0x0005F3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GDGNLHINKBM)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.GDGNLHINKBM);
			}
			if (this.ScriptId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.ScriptId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x00061208 File Offset: 0x0005F408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GDGNLHINKBM)
			{
				num += 2;
			}
			if (this.ScriptId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScriptId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x00061254 File Offset: 0x0005F454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClockParkQuitScriptCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GDGNLHINKBM)
			{
				this.GDGNLHINKBM = other.GDGNLHINKBM;
			}
			if (other.ScriptId != 0U)
			{
				this.ScriptId = other.ScriptId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x000612A4 File Offset: 0x0005F4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x000612B0 File Offset: 0x0005F4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ScriptId = input.ReadUInt32();
					}
				}
				else
				{
					this.GDGNLHINKBM = input.ReadBool();
				}
			}
		}

		// Token: 0x04000E14 RID: 3604
		private static readonly MessageParser<ClockParkQuitScriptCsReq> _parser = new MessageParser<ClockParkQuitScriptCsReq>(() => new ClockParkQuitScriptCsReq());

		// Token: 0x04000E15 RID: 3605
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E16 RID: 3606
		public const int GDGNLHINKBMFieldNumber = 2;

		// Token: 0x04000E17 RID: 3607
		private bool gDGNLHINKBM_;

		// Token: 0x04000E18 RID: 3608
		public const int ScriptIdFieldNumber = 9;

		// Token: 0x04000E19 RID: 3609
		private uint scriptId_;
	}
}
