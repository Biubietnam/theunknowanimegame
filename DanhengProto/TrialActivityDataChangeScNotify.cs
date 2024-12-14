using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013A1 RID: 5025
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TrialActivityDataChangeScNotify : IMessage<TrialActivityDataChangeScNotify>, IMessage, IEquatable<TrialActivityDataChangeScNotify>, IDeepCloneable<TrialActivityDataChangeScNotify>, IBufferMessage
	{
		// Token: 0x17003F07 RID: 16135
		// (get) Token: 0x0600E04D RID: 57421 RVA: 0x0025574F File Offset: 0x0025394F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrialActivityDataChangeScNotify> Parser
		{
			get
			{
				return TrialActivityDataChangeScNotify._parser;
			}
		}

		// Token: 0x17003F08 RID: 16136
		// (get) Token: 0x0600E04E RID: 57422 RVA: 0x00255756 File Offset: 0x00253956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TrialActivityDataChangeScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F09 RID: 16137
		// (get) Token: 0x0600E04F RID: 57423 RVA: 0x00255768 File Offset: 0x00253968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrialActivityDataChangeScNotify.Descriptor;
			}
		}

		// Token: 0x0600E050 RID: 57424 RVA: 0x0025576F File Offset: 0x0025396F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialActivityDataChangeScNotify()
		{
		}

		// Token: 0x0600E051 RID: 57425 RVA: 0x00255777 File Offset: 0x00253977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialActivityDataChangeScNotify(TrialActivityDataChangeScNotify other) : this()
		{
			this.trialActivityInfo_ = ((other.trialActivityInfo_ != null) ? other.trialActivityInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E052 RID: 57426 RVA: 0x002557AC File Offset: 0x002539AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialActivityDataChangeScNotify Clone()
		{
			return new TrialActivityDataChangeScNotify(this);
		}

		// Token: 0x17003F0A RID: 16138
		// (get) Token: 0x0600E053 RID: 57427 RVA: 0x002557B4 File Offset: 0x002539B4
		// (set) Token: 0x0600E054 RID: 57428 RVA: 0x002557BC File Offset: 0x002539BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialActivityInfo TrialActivityInfo
		{
			get
			{
				return this.trialActivityInfo_;
			}
			set
			{
				this.trialActivityInfo_ = value;
			}
		}

		// Token: 0x0600E055 RID: 57429 RVA: 0x002557C5 File Offset: 0x002539C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrialActivityDataChangeScNotify);
		}

		// Token: 0x0600E056 RID: 57430 RVA: 0x002557D3 File Offset: 0x002539D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrialActivityDataChangeScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.TrialActivityInfo, other.TrialActivityInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E057 RID: 57431 RVA: 0x00255808 File Offset: 0x00253A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.trialActivityInfo_ != null)
			{
				num ^= this.TrialActivityInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E058 RID: 57432 RVA: 0x00255844 File Offset: 0x00253A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E059 RID: 57433 RVA: 0x0025584C File Offset: 0x00253A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E05A RID: 57434 RVA: 0x00255855 File Offset: 0x00253A55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.trialActivityInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.TrialActivityInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E05B RID: 57435 RVA: 0x00255888 File Offset: 0x00253A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.trialActivityInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TrialActivityInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E05C RID: 57436 RVA: 0x002558C8 File Offset: 0x00253AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrialActivityDataChangeScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.trialActivityInfo_ != null)
			{
				if (this.trialActivityInfo_ == null)
				{
					this.TrialActivityInfo = new TrialActivityInfo();
				}
				this.TrialActivityInfo.MergeFrom(other.TrialActivityInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E05D RID: 57437 RVA: 0x0025591C File Offset: 0x00253B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E05E RID: 57438 RVA: 0x00255928 File Offset: 0x00253B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.trialActivityInfo_ == null)
					{
						this.TrialActivityInfo = new TrialActivityInfo();
					}
					input.ReadMessage(this.TrialActivityInfo);
				}
			}
		}

		// Token: 0x04005959 RID: 22873
		private static readonly MessageParser<TrialActivityDataChangeScNotify> _parser = new MessageParser<TrialActivityDataChangeScNotify>(() => new TrialActivityDataChangeScNotify());

		// Token: 0x0400595A RID: 22874
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400595B RID: 22875
		public const int TrialActivityInfoFieldNumber = 10;

		// Token: 0x0400595C RID: 22876
		private TrialActivityInfo trialActivityInfo_;
	}
}
