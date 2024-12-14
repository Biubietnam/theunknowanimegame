using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000387 RID: 903
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DeployRotaterCsReq : IMessage<DeployRotaterCsReq>, IMessage, IEquatable<DeployRotaterCsReq>, IDeepCloneable<DeployRotaterCsReq>, IBufferMessage
	{
		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06002824 RID: 10276 RVA: 0x0006FAED File Offset: 0x0006DCED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DeployRotaterCsReq> Parser
		{
			get
			{
				return DeployRotaterCsReq._parser;
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06002825 RID: 10277 RVA: 0x0006FAF4 File Offset: 0x0006DCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DeployRotaterCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06002826 RID: 10278 RVA: 0x0006FB06 File Offset: 0x0006DD06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeployRotaterCsReq.Descriptor;
			}
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x0006FB0D File Offset: 0x0006DD0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeployRotaterCsReq()
		{
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x0006FB15 File Offset: 0x0006DD15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeployRotaterCsReq(DeployRotaterCsReq other) : this()
		{
			this.rotaterData_ = ((other.rotaterData_ != null) ? other.rotaterData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x0006FB4A File Offset: 0x0006DD4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeployRotaterCsReq Clone()
		{
			return new DeployRotaterCsReq(this);
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x0600282A RID: 10282 RVA: 0x0006FB52 File Offset: 0x0006DD52
		// (set) Token: 0x0600282B RID: 10283 RVA: 0x0006FB5A File Offset: 0x0006DD5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RotaterData RotaterData
		{
			get
			{
				return this.rotaterData_;
			}
			set
			{
				this.rotaterData_ = value;
			}
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x0006FB63 File Offset: 0x0006DD63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeployRotaterCsReq);
		}

		// Token: 0x0600282D RID: 10285 RVA: 0x0006FB71 File Offset: 0x0006DD71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeployRotaterCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.RotaterData, other.RotaterData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600282E RID: 10286 RVA: 0x0006FBA4 File Offset: 0x0006DDA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rotaterData_ != null)
			{
				num ^= this.RotaterData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600282F RID: 10287 RVA: 0x0006FBE0 File Offset: 0x0006DDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002830 RID: 10288 RVA: 0x0006FBE8 File Offset: 0x0006DDE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x0006FBF1 File Offset: 0x0006DDF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rotaterData_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.RotaterData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002832 RID: 10290 RVA: 0x0006FC24 File Offset: 0x0006DE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rotaterData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RotaterData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x0006FC64 File Offset: 0x0006DE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeployRotaterCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rotaterData_ != null)
			{
				if (this.rotaterData_ == null)
				{
					this.RotaterData = new RotaterData();
				}
				this.RotaterData.MergeFrom(other.RotaterData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x0006FCB8 File Offset: 0x0006DEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x0006FCC4 File Offset: 0x0006DEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.rotaterData_ == null)
					{
						this.RotaterData = new RotaterData();
					}
					input.ReadMessage(this.RotaterData);
				}
			}
		}

		// Token: 0x04001024 RID: 4132
		private static readonly MessageParser<DeployRotaterCsReq> _parser = new MessageParser<DeployRotaterCsReq>(() => new DeployRotaterCsReq());

		// Token: 0x04001025 RID: 4133
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001026 RID: 4134
		public const int RotaterDataFieldNumber = 9;

		// Token: 0x04001027 RID: 4135
		private RotaterData rotaterData_;
	}
}
